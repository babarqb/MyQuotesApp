using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MyQuotesApp.models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyQuotesApp.api
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        new readonly List<Quote> _quotes = new List<Quote>
            {
                new Quote() {Id = 1, Content = "Happiness is not seomething ready", Author = "Babar QB"},
                new Quote() {Id = 2, Content = "Saddness is not seomething ready", Author = "Mohsin QB"},
                new Quote() {Id = 3, Content = "Lahore is not seomething ready", Author = "Waqar QB"},
                new Quote() {Id = 4, Content = "Karachi is not seomething ready", Author = "Raheel QB"},
            };
        // GET: api/values
        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Quote Get(int id)
        {
            var quote = _quotes.Find(q => q.Id == id);
            return quote;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
