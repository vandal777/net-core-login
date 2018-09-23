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

        ResourceEntity AddResource(int idTool, string link);
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

        public ResourceEntity AddResource(int idTool, string link)
        {
            var resource = new ResourceEntity { IdTool = idTool, Link = link };
            _context.Resources.Add(resource);
            _context.SaveChanges();
            return resource;
        }


        private IQueryable<ResourceEntity> GetResourceById(int id)
        {
            return _context.Resources.Where(x => x.IdTool == id);
        }
    }
}