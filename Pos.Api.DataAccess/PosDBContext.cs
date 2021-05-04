using Microsoft.EntityFrameworkCore;
using Pos.Api.DataAccess.Contracts;
using Pos.Api.DataAccess.Contracts.Entities;
using Pos.Api.DataAccess.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pos.Api.DataAccess
{
    public class PosDBContext : DbContext, IPosDBContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ExternalUserEntity> ExternalUsers { get; set; }

        public PosDBContext(DbContextOptions options) : base(options)
        {
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProductEntityConfig.SetEntityBuilder(modelBuilder.Entity<ProductEntity>());
            ExternalUserEntityConfig.SetEntityBuilder(modelBuilder.Entity<ExternalUserEntity>());
            base.OnModelCreating(modelBuilder);
        }

    }
}
