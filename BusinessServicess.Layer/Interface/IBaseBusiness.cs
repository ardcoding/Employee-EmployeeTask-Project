using OfficeDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServicess.Layer.Interface
{
    public interface IBaseBusiness<T> where T : IEntity
    {
        public Task<T> Add(T employee);
        public Task<List<T>> Get(Expression<Func<T, object>> value = null);
    }
}
