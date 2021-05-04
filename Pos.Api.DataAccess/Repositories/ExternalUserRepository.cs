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
    public class ExternalUserRepository : IExternalUserRepository
    {
        private readonly IPosDBContext _posDBContext;

        public ExternalUserRepository(IPosDBContext posDBContext)
        {
            _posDBContext = posDBContext;
        }

        public Task<ExternalUserEntity> Add(ExternalUserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ExternalUserEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ExternalUserEntity> DeleteAsync(int IdEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ExternalUserEntity> Get(int IdEntity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExternalUserEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ExternalUserEntity> GetById(int id)
        {
            ExternalUserEntity externalUser = await _posDBContext.ExternalUsers.FirstOrDefaultAsync(x => x.IdTercero == id);
            return externalUser;
        }

        public Task<int> Update(ExternalUserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ExternalUserEntity> Update(int IdEntity, ExternalUserEntity updateEnt)
        {
            throw new NotImplementedException();
        }

        Task<string> IRepository<ExternalUserEntity>.Update(ExternalUserEntity element)
        {
            throw new NotImplementedException();
        }
    }
}
