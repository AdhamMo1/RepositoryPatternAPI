using RepositoryPatternAPI.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternAPI.EF.Repositoris
{
    public class BaseRepository<T>(ApplicationDbContext _context) : IBaseRepository<T> where T : class
    {
        public T Find(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().FirstOrDefault(match);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
