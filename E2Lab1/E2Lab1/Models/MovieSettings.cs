using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E2Lab1.Models
{
    public class MovieSettings : MovieInterface
    {
        public List<Movie> AllMovies = new List<Movie>();

        public void Add(Movie newdata) 
        {
            AllMovies.Add(newdata);
        }
        public List<Movie> library()
        {
            List<Movie> getmovies = new List<Movie>();
            if (AllMovies.Count > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    getmovies.Add(AllMovies[AllMovies.Count - i]);
                }
            }
            else
            {
                for (int i = 0; i < AllMovies.Count; i++)
                {
                    getmovies.Add(AllMovies[i]);
                }
            }
            return getmovies;

        }
    }
}
