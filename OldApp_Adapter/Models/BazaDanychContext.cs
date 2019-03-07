using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OldApp_Adapter.Models
{
    public class BazaDanychContext
    {
        public List<Student> Studenci = new List<Student>
        {
            new Student
            {
                Id = 1,
                Imie = "kasia",
                Nazwisko = "www",
            },
                        new Student
            {
                Id = 2,
                Imie = "kacper",
                Nazwisko = "zzz",
            },
            new Student
            {
                Id = 3,
                Imie = "roman",
                Nazwisko = "kkk",
            }
        };
    }
}
