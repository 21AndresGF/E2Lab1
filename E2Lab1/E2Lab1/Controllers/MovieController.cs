using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using E2Lab1.Models;

namespace E2Lab1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        // GET: api/Movie/5
        [HttpGet]
        public List<Movie> Get()
        {
            MovieSettings set = new MovieSettings();
            return set.library();
        }

        // POST: api/Movie
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            MovieSettings moviepost = new MovieSettings();
            moviepost.Add(value);
        }

    }
}
