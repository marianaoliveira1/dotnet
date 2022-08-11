using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CRUD.Domain.Entities;
using System.Threading.Tasks;

namespace CRUD.Infra.Intrfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<T> Create(T obj);
        Task<T> Update(T obj);
        Task Remove(Long id);
        Task<T> Get(Long id);
        Task<List<T>> Get(Long id);

    }
}