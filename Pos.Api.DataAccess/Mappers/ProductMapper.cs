using Pos.Api.Business.Models;
using Pos.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pos.Api.DataAccess.Mappers
{
    public static class ProductMapper
    {
        public static ProductEntity Map(Product dto)
        {
            return new ProductEntity()
            {
              IdProducto = dto.IdProducto,
              NombreProducto = dto.NombreProducto,
              DescripcionProducto = dto.DescripcionProducto,
              TipoProducto =  dto.TipoProducto,
              Estado = dto.Estado,
              CategoriaProducto = dto.CategoriaProducto,
              CodigoBarras = dto.CodigoBarras,
              IdImpuesto = dto.IdImpuesto,
              CantidadEnBodega = dto.CantidadEnBodega,
              CantidadMinima = dto.CantidadMinima,
              CantidadMaxima = dto.CantidadMaxima,
              UnidadMedida = dto.UnidadMedida,
              FechaCreacion = dto.FechaCreacion,
              FechaActualizacion = dto.FechaActualizacion
            };
        }

        public static Product Map (ProductEntity entity)
        {
            return new Product()
            {
                IdProducto = entity.IdProducto,
                NombreProducto = entity.NombreProducto,
                DescripcionProducto = entity.DescripcionProducto,
                TipoProducto = entity.TipoProducto,
                Estado = entity.Estado,
                CategoriaProducto = entity.CategoriaProducto,
                CodigoBarras = entity.CodigoBarras,
                IdImpuesto = entity.IdImpuesto,
                CantidadEnBodega = entity.CantidadEnBodega,
                CantidadMinima = entity.CantidadMinima,
                CantidadMaxima = entity.CantidadMaxima,
                UnidadMedida = entity.UnidadMedida,
                FechaCreacion = entity.FechaCreacion,
                FechaActualizacion = entity.FechaActualizacion
            };
        }
    }
}
