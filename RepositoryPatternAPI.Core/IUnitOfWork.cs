using RepositoryPatternAPI.Core.Models;
using RepositoryPatternAPI.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternAPI.Core
{
    public interface IUnitOfWork
    {
        public IBaseRepository<Author> Authors { get; }
        public IBaseRepository<Book> Books { get; }
        int Save();
    }
}
