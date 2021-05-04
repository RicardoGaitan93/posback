using Pos.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Api.Application.Contracts.Services
{
    public interface IProductService
    {
        Task<Product> GetProductById(int id);
        Task <List<Product>> GetAllProducts();
        Task<string> CreateNewProduct(Product product);
        Task<string> UpdateProduct(Product product);


    }
}
