using System;
using System.ComponentModel.DataAnnotations;

namespace demo04.Models
{
    public class Student
    {
        [Key] // = Primary Key của SQL
         public int StudentId { get; set; }
        [Required] //=not null của SQL
        public string Name { get; set; }
        public void Show(){
            Console.WriteLine(this.Name);
        }
    }
}