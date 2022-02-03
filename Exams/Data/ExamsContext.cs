using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exams.Models;

namespace Exams.Data
{
    public class ExamsContext : DbContext
    {
        public ExamsContext (DbContextOptions<ExamsContext> options)
            : base(options)
        {
        }

        public DbSet<Exams.Models.Admin> Admin { get; set; }

        public DbSet<Exams.Models.Student> Student { get; set; }

        public DbSet<Exams.Models.Questions> Questions { get; set; }

        public DbSet<Exams.Models.Category> Category { get; set; }
    }
}
