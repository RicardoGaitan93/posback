using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pos.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pos.Api.DataAccess.EntityConfig
{
    public class ProductEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ProductEntity> entityBuilder)
        {
            entityBuilder.ToTable("Product");
            entityBuilder.HasKey(x => x.IdProducto);
            entityBuilder.Property(x => x.IdProducto).IsRequired();
        }
    }
}
