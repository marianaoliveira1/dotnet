using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Infra.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext()
        {}

        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {}

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer();
    }
}