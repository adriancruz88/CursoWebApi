using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI01.Models;

namespace WebAPI01.Controllers
{
    public class GeneroController : ApiController
    {


        [HttpPost]
        public async Task<IHttpActionResult> Get([FromBody]GeneroModel model)
        {
            try
            {

                Regex maleRegex = new Regex(model.MaleRegex, RegexOptions.IgnoreCase);
                Regex femaleRegex = new Regex(model.FemaleRegex, RegexOptions.IgnoreCase);
                
                Match male = maleRegex.Match(model.Name);
                Match female = femaleRegex.Match(model.Name);



                model.Result = "Indefinido";

                if (male.Success)
                {
                    model.Result = "Hombre";
                }

                if (female.Success)
                {
                    model.Result = "Mujer";
                }

                if (male.Success && female.Success)
                {
                    model.Result = "Indefinido";
                }

                return Ok(model);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpGet]
        public IHttpActionResult GetGenero()
        {
            try
            {
                GeneroModel g = new GeneroModel();
                g.MaleRegex = "fooRegex male";
                g.FemaleRegex = "fooRegex Female";
                g.Result = "indefinido";

                return Ok(g);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
