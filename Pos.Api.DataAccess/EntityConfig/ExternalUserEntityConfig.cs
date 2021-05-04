using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pos.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pos.Api.DataAccess.EntityConfig
{
    public class ExternalUserEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ExternalUserEntity> entityBuilder)
        {
            entityBuilder.ToTable("ExternalUser");
            entityBuilder.HasKey(x => x.IdTercero);
            entityBuilder.Property(x => x.IdTercero).IsRequired();
        }
    }
}
