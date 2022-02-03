using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exams.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa Kategorii")]
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }
        public virtual Admin Admin { get; set; }

    }
}
