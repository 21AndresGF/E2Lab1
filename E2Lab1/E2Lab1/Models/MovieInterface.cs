using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E2Lab1.Models
{
    interface MovieInterface
    {
        public void Add(Movie newdata);

        public List<Movie> library();
    }
}
