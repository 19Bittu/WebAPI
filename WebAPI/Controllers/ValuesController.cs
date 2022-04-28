using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {

        [HttpPost]
        [Route("/bfhl")]
        public Response Post([FromBody]Input newInput)
        {
            int i = 0;
            bool result = false;
            var response = new Response();
            response.numbers = new string[6];
            response.alphabets = new string[6];
            int k = 0;
            int j = 0;

            foreach (var item in newInput.data)
            {
                
               result = int.TryParse(item, out i); //i now = 108 
                if (result)
                    response.numbers[k] = item;
                else
                    response.alphabets[j] = item;

            }
            response.roll_number = "ABCD123";
            response.email = "john.xyz.com";
            response.is_success = true;
            response.user_id = "j_d_12345678";
            return response;
        }
    }
}
