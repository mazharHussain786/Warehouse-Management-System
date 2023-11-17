using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Identity.Client;

namespace ChatApplication.Models
{
    public partial class ChatDataBaseContext : DbContext
    {
        public ChatDataBaseContext()
        {

        }

        public ChatDataBaseContext(DbContextOptions<ChatDataBaseContext> options)
            : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Order>Orders { get; set; }
        public  DbSet<Product> Products { get; set; }// Define DbSet property here

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ChatDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
