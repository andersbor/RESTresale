using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTresale.Managers;
using RESTresale.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTresale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResaleItemsController : ControllerBase
    {
        private readonly ResaleItemsManagerDB _manager;

        public ResaleItemsController(SalesItemContext context)
        {
            _manager = new ResaleItemsManagerDB(context);
        }
        // a lot of REST methods


        // GET: api/<ResaleItemsController>
        [HttpGet]
        public IEnumerable<ResaleItem> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<ResaleItemsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ResaleItemsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ResaleItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResaleItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
