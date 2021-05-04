using Pos.Api.Business.Models;
using Pos.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pos.Api.DataAccess.Mappers
{
    public class ExternalUserMapper
    {
        public static ExternalUserEntity Map(ExternalUser dto)
        {
            return new ExternalUserEntity()
            {
                IdTercero = dto.IdTercero,
                NombreTercero = dto.NombreTercero,
                TipoTercero = dto.TipoTercero,
                Estado = dto.Estado,
                FechaCreacionTercero = dto.FechaCreacionTercero,
                TelefonoTercero1 = dto.TelefonoTercero1,
                TelefonoTercero2 = dto.TelefonoTercero2,
                TelefonoTercero3 = dto.TelefonoTercero3,
                DireccionTercero1 = dto.DireccionTercero1,
                DireccionTercero2 = dto.DireccionTercero2,
                ObservacionTercero = dto.ObservacionTercero    
            };
        }
        public static ExternalUser Map(ExternalUserEntity entity)
        {
            return new ExternalUser()
            {
                IdTercero = entity.IdTercero,
                NombreTercero = entity.NombreTercero,
                TipoTercero = entity.TipoTercero,
                Estado = entity.Estado,
                FechaCreacionTercero = entity.FechaCreacionTercero,
                TelefonoTercero1 = entity.TelefonoTercero1,
                TelefonoTercero2 = entity.TelefonoTercero2,
                TelefonoTercero3 = entity.TelefonoTercero3,
                DireccionTercero1 = entity.DireccionTercero1,
                DireccionTercero2 = entity.DireccionTercero2,
                ObservacionTercero = entity.ObservacionTercero
            };
        }
    }
}
