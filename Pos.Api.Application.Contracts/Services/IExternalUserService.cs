using Pos.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Api.Application.Contracts.Services
{
    public interface IExternalUserService
    {
        Task<ExternalUser> GetExternalUserByID(int id);
    }
}
