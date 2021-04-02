using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace HelloWorld.Pages
{
   
    public class TeacherModel : PageModel
    {
        public string Message { get; set; } = "Today is:";
        public List<Teacher> Teachers; 

        public void OnGet()
        {
            var id= 1;
            var classId = 1;

            var koen = new Teacher(id++, "Koen", classId++);
            var kanchan = new Teacher(id++, "Kanchan", classId++);
            var pepe = new Teacher(id++, "Pepe", classId++);
            var maria = new Teacher(id++, "Maria", classId++);

            Teachers = new List<Teacher> { koen, kanchan, pepe, maria };

        }
      
    }
}
