using Microsoft.AspNetCore.Mvc;
using Roulette.Api.Entities;
using Roulette.Api.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Roulette.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        
        private readonly ITableServices tableServices;


        public TableController(ITableServices tableServices)//Dependences Injections
        {
            this.tableServices = tableServices;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> CreateTable()
        {
            Table table = await tableServices.CreateTable();
            return Ok($"Created: {table.Id}");
        }
        [HttpPut("Open/{Id}")]
        public async Task<IActionResult> OpenTable([FromRoute(Name = "Id")] string Id)
        {
            try
            {
                Table  table = await tableServices.OpenTable(Id);
                return Ok($"Opened: {table.Id}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return StatusCode(405);
            }
        }
        [HttpGet("GetId/{Id}")]
        public async Task<IActionResult> GetTable([FromRoute(Name = "Id")] string Id)
        {
            try
            {
                Table table = await tableServices.GetTable(Id);
                return Ok(table);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return StatusCode(405);
            }
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllTables()
        {
            try
            {
                List<Table> tables = await tableServices.GetAllTables();
                return Ok(tables);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return StatusCode(405);
            }
        }
        [HttpPut("Close/{Id}")]
        public async Task<IActionResult> Close([FromRoute(Name = "Id")] string id)
        {
            try
            {
                Table table = await tableServices.CloseTable(id);
                return Ok(table);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return StatusCode(405);
            }
        }
        [HttpPut("Bet/{Id}/{UserId}/{Money}/{Box}/{Color}")]
        public async Task<IActionResult> Bet([FromRoute(Name = "Id")] string id,
                                             [FromRoute(Name = "UserId")] string userId,
                                             [FromRoute(Name = "Money")] double money,
                                             [FromRoute(Name = "Box")] int box=-1,
                                             [FromRoute(Name = "Color")] string color="")
        {

            try
            {
                Bet bet = new Bet()
                {
                    UserId = userId,
                    Money = money,
                    Box = box,
                    Color = color
                };
                Table table = await tableServices.SetBet(id, bet);
                return Ok(table);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return StatusCode(405);
            }
        }
    }
}
