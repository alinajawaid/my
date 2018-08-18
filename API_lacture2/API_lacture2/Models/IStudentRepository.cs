using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_lacture2.Models
{
    interface IStudentRepository
    {

        IEnumerable<Student> GetAllStudents();

        Student AddStudent(Student student);
    }
}
