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
        
        public string Title { get; set; }
        
        //public List<string> Links { get; set;} 
    }
}