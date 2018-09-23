using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Dtos;

namespace WebApi.Services
{
    public interface IToolService
    {
        IList<ToolDto> GetAll();

        ToolDto AddTool(ToolDto toolDto);

    }

    public class ToolService : IToolService
    {
        private ToolDataContext _context;
        private IResourceService _resourceService;

        private static List<ToolDto> toolsDTO = new List<ToolDto>();


        public ToolService(IResourceService resourceService, ToolDataContext context)
        {
            _context = context;
            _resourceService = resourceService;
        }

        public IList<ToolDto> GetAll()
        {
            if(toolsDTO.Count == 0)
            {
                var toolsWithoutLinks = _context.Tools;           
                foreach(var tool in toolsWithoutLinks)
                {
                    toolsDTO
                    .Add(
                        new ToolDto
                        {
                            Description = tool.Description,
                            Name = tool.Name,
                            Title = tool.Title, 
                            Links =   _resourceService.GetLinks(tool.Id).ToList()                   
                        });
                }
                return toolsDTO;
            }
            else
            {
                return toolsDTO;
            }
        }

        public ToolDto AddTool(ToolDto toolDto)
        {
            var tool = new ToolEntity 
            {
                Name = toolDto.Name,
                Description = toolDto.Description,
                Title = toolDto.Title
            };         

            _context.Tools.Add(tool);
            _context.SaveChanges();

            foreach(var link in toolDto.Links)
            {
                _resourceService.AddResource(tool.Id, link);
            }
            toolsDTO.Add(toolDto);
            return toolDto;
        }      

        /* public Tool GetToolById(int id)
        {
                //todo refactor
        }
*/
    }
}