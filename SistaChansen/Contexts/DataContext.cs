﻿using Microsoft.EntityFrameworkCore;
using SistaChansen.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistaChansen.Contexts
{
    internal class DataContext : DbContext
    {

        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hundmamma\OneDrive\Skrivbord\SqlCourse\SistaChansen\SistaChansen\Contexts\local_sc_db.mdf;Integrated Security=True;Connect Timeout=30";

        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString);
        }



        public DbSet<TicketEntity> Ticket { get; set; } = null!;
        public DbSet<StatusEntity> Status { get; set; } = null!;
        public DbSet<CommentEntity> Comment { get; set; } = null!;
        public DbSet<CustomerEntity> Customer { get; set; } = null!;

    }
}
