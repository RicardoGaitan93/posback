using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Api.DataAccess.Contracts.IRepositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T element);
        Task<T> Delete(int id);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<string> Update(T element);
        Task<bool> Exist(int id);
    }
}
