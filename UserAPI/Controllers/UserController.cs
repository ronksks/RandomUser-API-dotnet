using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Newtonsoft.Json;
using System.Net;
using System.Reflection;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace UserAPI.Controllers
    {

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
        {

        // GET: api/<UserController>
        [HttpGet("GetRandomUser")]

        public User GetRandomUser()
            {
            // Create an instance of HttpClient
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://randomuser.me/");

            // Send a GET request to the API endpoint
            var response = client.GetAsync("api/").Result;
            if (response.StatusCode == HttpStatusCode.OK)
                {
                var responseString = response.Content.ReadAsStringAsync().Result;
                User randomUser = JsonConvert.DeserializeObject<User>(responseString);
                return randomUser;
                }
            else
                {
                throw new Exception($"Failed to retrieve user with status code {response.StatusCode}");
                }


            }


        // GET api/<UserController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //    {
        //    return "value";
        //    }

        //// POST api/<UserController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //    {
        //    }

        //// PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //    {
        //    }

        //// DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //    {
        //    }
        }
    }
