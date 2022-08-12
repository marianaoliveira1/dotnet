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
        Task Remove(long id);
        Task<T>  Get(long id);
        Task<List<T>> Get();

    }
}