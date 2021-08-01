using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using MyMicroservice.Models;
using MyMicroservice.Repository;
using Microsoft.AspNetCore.Http;

namespace MyMicroservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GameController: ControllerBase
    {
        
        [HttpGet("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Game))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetGame(String name)
        {
            
            try
            {       
                Services.GameServices service = new Services.GameServices();
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
        public IActionResult insertGame(Game article)
        {
            try
            {
                Services.GameServices service = new Services.GameServices();

                service.InsertGame(article);

                return Ok("Articulo ingresado Correctamente.");
            }
            catch(Exception e)
            { 
                return BadRequest(e.Message);
            }
        }
    }
}
