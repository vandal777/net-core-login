using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Services
{
    public interface IResourceService
    {
        IEnumerable<string> GetLinks(int id);

        Resource AddResource(int idTool, string link);
    }

    public class ResourceService : IResourceService
    {
        private ToolDataContext _context;
        public ResourceService(ToolDataContext context)
        {
            _context = context;
        }

        public IEnumerable<string> GetLinks(int id)
        {
            return GetResourceById(id).Select(x => x.Link).ToList();          
        }

        public Resource AddResource(int idTool, string link)
        {
            var resource = new Resource { IdTool = idTool, Link = link };
            _context.Resources.Add(resource);
            _context.SaveChanges();
            return resource;
        }


        private IQueryable<Resource> GetResourceById(int id)
        {
            return _context.Resources.Where(x => x.IdTool == id);
        }
    }
}