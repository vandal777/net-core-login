using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Dtos;
using WebApi.Entities;

namespace WebApi.Services
{
    public interface IRoleService
    {
        void Create(string roleName);

        bool RoleExists(string name);
    }

    public class RoleService : IRoleService
    {
        private readonly UserDataContext _context;

        public RoleService(UserDataContext context)
        {
            _context = context;
        }

        public void Create(string roleName)
        {
            _context.Roles.Add(new RoleEntity { Name = roleName });
            _context.SaveChanges();
        }

        public bool RoleExists(string name)
        {
            return _context.Roles.Find(name) != null ? true : false;
        }    
    }
}
