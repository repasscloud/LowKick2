using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lowkick2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadContollerController : ControllerBase
    {
        // GET: api/FileUploadContoller
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FileUploadContoller/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FileUploadContoller
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/FileUploadContoller/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/FileUploadContoller/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
