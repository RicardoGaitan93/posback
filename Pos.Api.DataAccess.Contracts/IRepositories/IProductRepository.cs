using Pos.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Api.DataAccess.Contracts.IRepositories
{
    public interface IProductRepository : IRepository<ProductEntity>
    {
        Task<ProductEntity> Add(ProductEntity entity);
        Task<ProductEntity> Delete(int IdEntity);
        Task<ProductEntity> Get(int IdEntity);
        Task<IEnumerable<ProductEntity>> GetAll();
        Task<string> Update(ProductEntity entity);
    }
}
