using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities

{
    public class Resource
    {
        public int Id { get; set; }
        public string Link { get; set;} 
        public int IdTool { get; set; }

    }
}