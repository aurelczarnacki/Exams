using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exams.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa Użytkownika")]
        [Required(ErrorMessage = "*")]
        public string UserName { get; set; }
        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "*")]
        public string Password { get; set; }

    }
}
