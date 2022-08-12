using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Domain.Entities;
using CRUD.Infra.Context;
using CRUD.Infra.Intrfaces;

namespace CRUD.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    
    {
        private readonly CRUDContext _context;
        public UserRepository(CRUDContext context) : base(context)
        {
            _context = context;
        } 

        public async Task<User> GetByEmail(string email)
        {
            var user = await _context.Users.Where(x => x.Email.ToLower() == email.ToLower()).AsNoTracking().ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<List<User>> SearchByEmail(string email)
        {
            var allUsers = await _context.Users(x => x.Email.ToLower() == email.ToLower()).AsNoTracking().ToListAsync();

            return allUsers;
        }

     public async Task<List<User>> SearchByName(string name)
        {
            var allUsers = await _context.Users(x => x.Name.ToLower() == name.ToLower()).AsNoTracking().ToListAsync();

            return allUsers;
        }       
    }
}