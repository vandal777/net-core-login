using System.Collections;
using System;
using System.Collections.Generic;

namespace WebApi.Entities

{
    public class Tool
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<string> Links { get; set;} 
    }
}