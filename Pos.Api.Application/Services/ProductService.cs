using Pos.Api.Application.Contracts.Services;
using Pos.Api.Business.Models;
using Pos.Api.DataAccess.Contracts.IRepositories;
using Pos.Api.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Api.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        /// <summary>
        /// Buscar un producto por ID
        /// </summary>
        /// <param name="idProduct"></param>
        /// <returns>entidad producto </returns>
        public async Task<Product> GetProductById(int idProduct)
        {
            var prod = await _productRepository.Get(idProduct);
            return ProductMapper.Map(prod);
        }
        /// <summary>
        /// Buscar todos los productos registrados
        /// </summary>
        /// <returns>Todos los productos activos</returns>
        public async Task<List<Product>> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            
            var lstProds = await _productRepository.GetAll();

            foreach (var item in lstProds)
            {
                products.Add(ProductMapper.Map(item));
            }
            return products;
        }


        public async Task<string> CreateNewProduct(Product product)
        {
            var result = await _productRepository.Add(ProductMapper.Map(product));
            return "ok";
        }

        public async Task<string> UpdateProduct(Product product)
        {
            var result = await _productRepository.Update(ProductMapper.Map(product));
            
            return result.ToString();
        }


    }
}
