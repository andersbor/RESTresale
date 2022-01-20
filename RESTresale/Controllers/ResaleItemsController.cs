using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RESTresale.Managers;
using RESTresale.Models;
using Microsoft.AspNetCore.Http;

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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ResaleItem>> Get()
        {
            return Ok(_manager.GetAll());
        }

        // GET api/<ResaleItemsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ResaleItem> Get(int id)
        {
            ResaleItem item = _manager.GetById(id);
            if (item == null) return NotFound("No such item, id: " + id);
            return Ok(item);
        }

        // POST api/<ResaleItemsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<ResaleItem> Post([FromBody] ResaleItem value)
        {
            ResaleItem item = _manager.Add(value);
            string uri = Url.RouteUrl(RouteData.Values) + "/" + item.Id;
            return Created(uri, item);
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
