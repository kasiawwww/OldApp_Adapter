using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OldApp_Adapter.Models.Target
{
    public interface IStudentRepo
    {
        void Add(StudentDTO student);
        void Delete(int id);
        List<StudentDTO> GetList();

    }
}
