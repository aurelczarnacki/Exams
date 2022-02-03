using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exams.Models
{
    public class SetExam
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual Student Student { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
