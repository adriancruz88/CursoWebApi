using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI01.Controllers
{
    public class HelloController : ApiController
    {
        // GET: api/Hello
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return new string[] { "Hola", "Mundo" };
        }

        // GET: api/Hello/5
        public string Get(int id)
        {
            //return "value";
            return "Tu id es: " + id;
        }

        // POST: api/Hello
        public void Post([FromBody]string value)
        {
            string foo = "en Post con value: " + value;
        }

        // PUT: api/Hello/5
        public void Put(int id, [FromBody]string value)
        {

            string foo = String.Concat("en Put con value: ", value, " y id :", id);
        }

        // DELETE: api/Hello/5
        public void Delete(int id)
        {
            string foo = "en Delete con id: " + id;
        }
    }
}
