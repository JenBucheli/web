using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnetWeb.Models;

namespace HelloWorld.Pages
{
    public class StudentModel : PageModel
    {
        public string Message { get; set; } = "Today is:";
        public List<Student> Students;

        public void OnGet()
        {
            var id = 1;

            var benjamin = new Student(id++, "Benjamin", 1);
            var nattaya = new Student(id++, "Nattaya", 1);
            var steven = new Student(id++, "Steven", 2);
            var laila = new Student(id++, "Laila", 1);
            var elias = new Student(id++, "Elias", 3);

            Students = new List<Student> { benjamin, nattaya, steven, laila, elias };
        }
    }
}
