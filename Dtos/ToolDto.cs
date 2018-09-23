using System.Collections;
using System;
using System.Collections.Generic;
namespace WebApi.Dtos
{
    public class ToolDto
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Links {get; set;} 
        
    }
}