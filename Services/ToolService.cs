using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Services
{
    public interface IToolService
    {
        IEnumerable<Tool> getAll();
    }

    public class ToolService : IToolService
    {
        private ToolDataContext _context;
        public ToolService(ToolDataContext context)
        {
            _context = context;
        }

        public IEnumerable<Tool> getAll()
        {
            return _context.Tools;
        }
    }
}