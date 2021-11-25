using System;
using System.Linq;
using demo04.EF;
using demo04.Models;

namespace demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext(); //connect context

            //ADD
            // var std = new Student()
            //     {
            //          Name = "Tom"
            //     };

            // context.Students.Add(std); //add vào bảng student
            // context.SaveChanges();
            //GET ALL
            // var students = context.Students.ToList();
            // foreach (var item in students)
            // {
            //     item.Show();
            // }
            //GET BY ID
            // var studentById = context.Students.Where(s=>s.StudentId == 1).ToList();
            // foreach (var item in studentById)
            // {
            //     item.Show();
            // }
            //UPDATE
            // var std = context.Students.First<Student>(); 
            // std.Name = "Steve";
            // context.SaveChanges();

            //REMOVE
            // var std = context.Students.First(p=>p.StudentId==2);
            // context.Students.Remove(std);
            // context.SaveChanges();
        }
    }
}
