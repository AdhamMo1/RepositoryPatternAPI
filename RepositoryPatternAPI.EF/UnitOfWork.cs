using RepositoryPatternAPI.Core;
using RepositoryPatternAPI.Core.Models;
using RepositoryPatternAPI.Core.RepositoryInterfaces;
using RepositoryPatternAPI.EF.Repositoris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternAPI.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Authors = new BaseRepository<Author>(_context);
            Books = new BaseRepository<Book>(_context);
        }

        public IBaseRepository<Author> Authors { get; private set; }

        public IBaseRepository<Book> Books { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
