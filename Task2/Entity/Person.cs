using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Entity
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile  File { get; set; }
    }
}
