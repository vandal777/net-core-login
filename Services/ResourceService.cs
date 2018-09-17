using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Services
{
    public interface IResourceService
    {
        IEnumerable<string> AddLinks(int id);
    }

    public class ResourceService : IResourceService
    {
        private ResourceDataContext _context;
        public ResourceService(ResourceDataContext context)
        {
            _context = context;
        }

        public IEnumerable<string> AddLinks(int id)
        {
            return GetResourceById(id).Select(x => x.Link).ToList();          
        }

        private IQueryable<Resource> GetResourceById(int id)
        {
            return _context.Resources.Where(x => x.IdTool == id);
        }
    }
}