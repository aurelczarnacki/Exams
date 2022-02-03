using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exams.Models
{
    public class Questions
    {
        public int Id { get; set; }
        [Display(Name = "Pytanie:")]
        [Required]
        public string Question { get; set; }
        [Display(Name = "Opcja 1:")]
        [Required]
        public string Option1 { get; set; }
        [Display(Name = "Opcja 2:")]
        [Required]
        public string Option2 { get; set; }
        [Display(Name = "Opcja 3:")]
        [Required]
        public string Option3 { get; set; }
        [Display(Name = "Opcja 4:")]
        [Required]
        public string Option4 { get; set; }
        [Display(Name = "Poprawna Odpowiedź:")]
        [Required]
        public string CorrectAnswer { get; set; }

        [ForeignKey("Categories")]
        public ICollection<Category> Category { get; set; }
    }
}
