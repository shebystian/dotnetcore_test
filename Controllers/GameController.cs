using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using MyMicroservice.Models;
using MyMicroservice.Repository;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace MyMicroservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GameController: ControllerBase
    {        
        private Services.GameServices service;

        [HttpGet("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Game))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(String name)
        {
            
            try
            {  
                service = new Services.GameServices();     
                Game game = new Game();
                game = service.GetGame(name);

                if(game == null)
                    return NotFound();
                else
                    return Ok(game);
            }
            catch(Exception e)
            { 
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Game))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Post([FromBody] Game article)
        {
            try
            {
                service = new Services.GameServices();
                service.InsertGame(article);

                return Ok("Articulo ingresado Correctamente.");
            }
            catch(Exception e)
            { 
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Game))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetList()
        {
            try
            {    
                service = new Services.GameServices();

                var game = new List<Game>();
                game = service.GetGames();

                if(game == null)
                    return NotFound();
                else
                    return Ok(game);
            }
            catch(Exception e)
            { 
                return BadRequest(e.Message);
            }
        }

    } 
}
