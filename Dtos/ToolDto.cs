using System.Collections;
namespace WebApi.Dtos
{
    public class ToolDto
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable Links {get; set;} 
        
    }
}