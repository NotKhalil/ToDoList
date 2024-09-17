using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Domain.Models;

namespace UserManagement.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=Khalilzin\SQLEXPRESS;database=ToDoList; User ID=sa;Password=123456;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True; Encrypt=false");
        }
        public DbSet<User> Users { get; set; }

    }
}
