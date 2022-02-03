using System;
using System.Collections.Generic;
namespace WebApplication1.Models
{
    public class StudentDetail
    {
        public string studentName { get; set; }

        public int studentId { get; set; }  

        public string studentStatus { get; set; }   
    }

    public class listStudent
    {
        public List<StudentDetail> GetStudentDetails()
        {
            StudentDetail student1 = new StudentDetail();
            student1.studentName = "Shubham";
            student1.studentId = 1234;
            student1.studentStatus = "PASS";

            StudentDetail student2 = new StudentDetail();
            student2.studentName = "Vijay";
            student2.studentId = 3434;
            student2.studentStatus = "FAIL";

            List<StudentDetail> session = new List<StudentDetail>();
            session.Add(student1);
            session.Add(student2);

            return session;
        }
    }
}
