using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternAPI.Core.RepositoryInterfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        T Find(Expression<Func<T,bool>> match);
    }
}
