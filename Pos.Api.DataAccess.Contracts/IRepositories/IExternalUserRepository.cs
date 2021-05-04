using Pos.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Api.DataAccess.Contracts.IRepositories
{
    public interface IExternalUserRepository: IRepository<ExternalUserEntity>
    {
        Task<ExternalUserEntity> Add(ExternalUserEntity entity);
        Task<ExternalUserEntity> DeleteAsync(int IdEntity);
        Task<ExternalUserEntity> Get(int IdEntity);
        Task<int> Update(ExternalUserEntity entity);
        Task<ExternalUserEntity> Update(int IdEntity, ExternalUserEntity updateEnt);
    }
}
