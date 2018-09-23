using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.IdentityModel.Tokens.Jwt;
using WebApi.Helpers;
using Microsoft.Extensions.Options;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using WebApi.Services;
using WebApi.Dtos;
using WebApi.Entities;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ToolsController : ControllerBase
    {
        private IToolService _toolService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public ToolsController(
            IToolService toolService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _toolService = toolService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [HttpGet]     
        public IActionResult GetAll()
        {
            var tools =  _toolService.GetAll();
            var toolDtos = _mapper.Map<IList<ToolDto>>(tools);
            return Ok(toolDtos);
        }

        [HttpPost]
        public IActionResult Add(ToolDto toolDto)
        {
            
            return Ok(_toolService.AddTool(toolDto));
        }

        [HttpPut]
        public IActionResult Update(ToolDto toolDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public IActionResult Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
