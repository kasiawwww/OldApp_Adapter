using OldApp_Adapter.Models.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OldApp_Adapter.Models.Adapter
{
    public class StudentRepo : IStudentRepo
    {
        BazaDanychContext context;
        public StudentRepo(BazaDanychContext context)
        {
            this.context = context;
        }
        public void Add(StudentDTO student)
        {
            Student oldItem = new Student
            {
                Id = student.Id,
                Imie = student.Name,
                Nazwisko = student.LastName,
            };
            context.Studenci.Add(oldItem);
        }

        public void Delete(int id)
        {
            var oldStudent = context.Studenci.FirstOrDefault(a => a.Id = id);
            context.Studenci.Remove(oldStudent);
        }

        public List<Student> GetList()
        {
            return context.Studenci.Select(s => new StudentDTO
            {
                Id = s.Id,
                Name = s.Imie,
                LastName = s.Nazwisko
            }).ToList();
        }
    }
}
