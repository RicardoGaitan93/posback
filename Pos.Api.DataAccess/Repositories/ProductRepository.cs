using Microsoft.EntityFrameworkCore;
using Pos.Api.DataAccess.Contracts;
using Pos.Api.DataAccess.Contracts.Entities;
using Pos.Api.DataAccess.Contracts.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Api.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IPosDBContext _posDBContext;

        public ProductRepository(IPosDBContext posDBContext)
        {
            _posDBContext = posDBContext;
        }

        public async Task<ProductEntity> Add(ProductEntity entity)
        {
            try
            {
                ProductEntity pe = new ProductEntity();
                pe.CantidadEnBodega = entity.CantidadEnBodega;
                pe.CantidadMaxima = entity.CantidadMaxima;
                pe.CantidadMinima = entity.CantidadMinima;
                pe.CategoriaProducto = entity.CategoriaProducto;
                pe.CodigoBarras = entity.CodigoBarras;
                pe.DescripcionProducto = entity.DescripcionProducto;
                pe.Estado = entity.Estado;
                pe.FechaActualizacion = entity.FechaActualizacion;
                pe.FechaCreacion = entity.FechaCreacion;
                pe.IdImpuesto = entity.IdImpuesto;
                pe.NombreProducto = entity.NombreProducto;
                pe.TipoProducto = entity.TipoProducto;
                pe.UnidadMedida = entity.UnidadMedida;


                await _posDBContext.Products.AddAsync(pe);
                await _posDBContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {

            }
            throw new NotImplementedException();
        }

        public Task<ProductEntity> Delete(int IdEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductEntity> Get(int IdEntity)
        {
            ProductEntity result = await _posDBContext.Products.FirstOrDefaultAsync(x => x.IdProducto == IdEntity);
            return result;
        }

        public async Task<IEnumerable<ProductEntity>> GetAll()
        {
            List<ProductEntity> listProd = new List<ProductEntity>();

            try
            {
                listProd = await _posDBContext.Products.Where(x => x.Estado).ToListAsync();
                //List<ProductEntity> listProd1 = await _posDBContext.Products.ToListAsync();
            }
            catch (Exception error)
            {
                throw error;
            }
            return listProd;
        }

        public async Task<string> Update(ProductEntity entity)
        {
            try
            {
                //var pddd = _posDBContext.Products.FirstAsync(x => x.IdProducto == entity.IdProducto).Result;

                var Prod = _posDBContext.Products.Update(entity);
                var restult = await _posDBContext.SaveChangesAsync();
                return restult.ToString();
            }
            catch (Exception error)
            {
                return error.Message.ToString();
            }
        }
    }
}
