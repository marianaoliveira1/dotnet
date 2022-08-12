using System.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD.Infra.Intrfaces;
using CRUD.Domain.Entities;
using CRUD.Infra.Context;

namespace CRUD.Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        private readonly CRUDContext _context;

        public BaseRepository(CRUDContext context)
        {
            _context = context;
        }

        public virtual async Task<T> Create(T obj) 
        {
            _context.Add(obj);
            await _context.SaveChangeAsync();

            return obj;
        }

        public virtual async Task<T> Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangeAsync();

            return obj;
        }

        public virtual async Task Remove(long id)
        {
            var obj = await GetAllAsyn(id);

            if(obj !=null)
            {
                _context.Remove(obj);
                await _context.SaveChangeAsync();
            }
        }

        public virtual async Task<T> Get(long id)
        {
            var obj = await _context.Set<T>()
                                .AsNoTracking()
                                .Where(x=>xId == id)
                                .ToListAsync();

            return GCLargeObjectHeapCompactionMode.FirstOrDefault();
        }

        public virtual async Task<List<T>> Get()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }
    }
}