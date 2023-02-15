﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;



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


        //GET api/<UserController>/5
        [HttpGet("RandomUsersByGender")]
        public User GetMultipleRandomUsersWithGender(int numOfUsers, string gender)
            {
            // Create an instance of HttpClient
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://randomuser.me/");

            // Send a GET request to the API endpoint
            var response = client.GetAsync("api/?results=" + numOfUsers + "&gender=" + gender).Result;
            if (response.StatusCode == HttpStatusCode.OK)
                {
                var responseString = response.Content.ReadAsStringAsync().Result;
                User randomUsers = JsonConvert.DeserializeObject<User>(responseString);
                return randomUsers;
                }
            else
                {
                throw new Exception($"Failed to retrieve user with status code {response.StatusCode}");
                }


            }

        //GET api/<UserController>/5
        [HttpGet("GetMostPopularContryFrom5000RandomUsers")]
        public string GetMostPopularCountry()
            {
            // Create an instance of HttpClient
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://randomuser.me/");

            // Send a GET request to the API endpoint
            var response = client.GetAsync("api/?results=5000").Result;
            Dictionary<string, int> countryDict = new Dictionary<string, int>();

            if (response.StatusCode == HttpStatusCode.OK)
                {
                var responseString = response.Content.ReadAsStringAsync().Result;

                User randomUsers = JsonConvert.DeserializeObject<User>(responseString);
                Console.WriteLine(randomUsers.Results.First().location.country);
                int maxValue = 0;
                string mostPopularCountry = "";
                for (int i = 0; i < randomUsers.Results.Count; i++)
                    {
                    string curCountry = randomUsers.Results[i].location.country;

                    if (countryDict.ContainsKey(curCountry))
                        {
                        countryDict[curCountry]++;
                        }
                    else
                        {
                        countryDict.Add(curCountry, 1);
                        }
                    }
                mostPopularCountry = countryDict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

                //foreach (User user in randomUsers.Results.First().location.country)
                //    {
                //    if (countryDict.ContainsKey(user.)
                //    }

                return ($"The most popular contry of 5000 users is: {mostPopularCountry}");
                }
            else
                {
                throw new Exception($"Failed to retrieve user with status code {response.StatusCode}");
                }


            }

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
