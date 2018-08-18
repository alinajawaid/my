using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_lacture2.Models
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> items = new List<Student>();
        private int next = 1;

     public StudentRepository()
        {
            AddStudent(new Student { ID = 1, Name = "Asma", City = "Dubai", Course = "B.tech" });
            AddStudent(new Student { ID = 2, Name = "Mahnoor", City = "England", Course = "B.Com" });
            AddStudent(new Student { ID = 3, Name = "Alina", City = "Australia", Course = "MBA" });
            AddStudent(new Student { ID = 4, Name = "Areesha", City = "Saudia", Course = "BSCs" });
            AddStudent(new Student { ID = 5, Name = "Madiha", City = "Pakistan", Course = "BS" });
        }

        public IEnumerable<Student> GetAllStudent()
     {
         return items;
     }


    public Student AddStudent(Student student)
     {
         if (items == null)
         {
             throw new ArgumentNullException("student");
         }

         student.ID = next++;
         items.Add(student);
         return student;
     }

    

    }
}