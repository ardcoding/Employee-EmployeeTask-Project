using OfficeDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Interface
{
    public interface IBaseRepository<T> where T : IEntity
    {
            public Task<T> Add(T entity);
            public Task<List<T>> Get(Expression<Func<T, object>> value = null);
        
    }
}

