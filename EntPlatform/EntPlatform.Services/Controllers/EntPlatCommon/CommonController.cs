using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntPlatform.Services.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EntPlatform.Services.Controllers.EntPlatCommon
{
    [Route("api/[controller]")]
    public class CommonController : Controller
    {
        private readonly EntPlaformContext _context;
        public CommonController(EntPlaformContext context)
        {
            _context = context;
        }

        [Route("GetState")]
        public IActionResult GetState()
        {
           
                var states = from x in _context.State
                             orderby x.StateName
                             select x;
                if (states.Count() > 0)
                {
                   
                    return Ok(states.ToList());
                }
                else
                {
                    return NotFound();
                }
        }

        [Route("GetCountry")]
        public IActionResult GetCountry()
        {
           
                var countries = from x in _context.Country
                                orderby x.Name
                                select x;
                if (countries.Count() > 0)
                {
                   
                    return Ok(countries.ToList());
                }
                else
                {
                    return NotFound();
                }
           
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
