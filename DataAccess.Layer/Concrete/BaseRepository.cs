using DataAccess.Layer.Interface;
using Microsoft.EntityFrameworkCore;
using OfficeDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity
    {
        private readonly OfficeDbContext _dbcontext;

        public BaseRepository(OfficeDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        public async Task<T> Add(T entity)
        {
            await _dbcontext.Set<T>().AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> Get(Expression<Func<T, object>> value = null)
        {
            return await _dbcontext.Set<T>().Include(value).ToListAsync();

        }
    }
}
