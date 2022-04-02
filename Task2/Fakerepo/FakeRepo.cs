using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Entity;

namespace Task2.Fakerepo
{
    public class FakeRepo
    {
        public static List<Person> Persons = new List<Person>
               {
                   new Person{ Name="Lala",Surname="Muradova",Age=27,ImageUrl="1.jpg"},
                   new Person{ Name="Omer",Surname="Muradov",Age=27,ImageUrl="2.jpg"},
                   new Person { Name = "Kamran", Surname = "Muradli", Age = 27, ImageUrl = "3.jpg" },
                   new Person { Name = "Fidan", Surname = "Hesenova", Age = 27, ImageUrl = "4.jpg" }
               };
    }
}
