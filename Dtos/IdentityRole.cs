using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class IdentityRole
    {
        public IdentityRole(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
