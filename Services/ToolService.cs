using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Services
{
    public interface IToolService
    {
        IList<Tool> getAll();
    }

    public class ToolService : IToolService
    {
        private ToolDataContext _context;
        private IResourceService _resourceService;

        public ToolService(IResourceService resourceService, ToolDataContext context)
        {
            _context = context;
            _resourceService = resourceService;
        }

        public IList<Tool> getAll()
        {
            var toolsWithoutLinks = _context.Tools;

            foreach(var tool in toolsWithoutLinks)
            {
                tool.Links = _resourceService.AddLinks(tool.Id).ToList();
            }

            return toolsWithoutLinks.ToList();
        }

        /* public Tool GetToolById(int id)
        {
                //todo refactor
        }
*/
    }
}