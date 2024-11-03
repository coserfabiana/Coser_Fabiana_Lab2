using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coser_Fabiana_Lab2.Models;

namespace Coser_Fabiana_Lab2.Data
{
    public class Coser_Fabiana_Lab2Context : DbContext
    {
        public Coser_Fabiana_Lab2Context (DbContextOptions<Coser_Fabiana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Coser_Fabiana_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Coser_Fabiana_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Coser_Fabiana_Lab2.Models.Authors> Authors { get; set; } = default!;
        public DbSet<Coser_Fabiana_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
