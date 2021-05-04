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
    public class ExternalUserService : IExternalUserService
    {
        private readonly IExternalUserRepository _externalUserRepository;

        public ExternalUserService(IExternalUserRepository externalUserRepository)
        {
            _externalUserRepository = externalUserRepository;
        }
        public async Task<ExternalUser> GetExternalUserByID(int id)
        {
            var prod = await _externalUserRepository.Get(id);
            return ExternalUserMapper.Map(prod);

        }
    }
}
