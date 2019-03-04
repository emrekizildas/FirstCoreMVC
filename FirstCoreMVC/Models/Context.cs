using System;
using Microsoft.EntityFrameworkCore;

namespace FirstCoreMVC.Models
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options)
        : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}

