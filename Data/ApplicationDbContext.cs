using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotesApplication.Models;

namespace NotesApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<NotesItem> NoteItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=NotesDB;Trusted_Connection=True;");
        }
    }
}
