using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gabor_Patricia_Lab2.Models;

namespace Gabor_Patricia_Lab2.Data
{
    public class Gabor_Patricia_Lab2Context : DbContext
    {
        public Gabor_Patricia_Lab2Context (DbContextOptions<Gabor_Patricia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Gabor_Patricia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Gabor_Patricia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Gabor_Patricia_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Gabor_Patricia_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Gabor_Patricia_Lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Gabor_Patricia_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
