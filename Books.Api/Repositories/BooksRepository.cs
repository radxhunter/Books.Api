using Books.Api.Contexts;
using Books.Api.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Api.Repositories
{
    public class BooksRepository : IBooksRepository, IDisposable
    {
        private BooksContext _context;

        public BooksRepository(BooksContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Book>> GetBooks()
            => await _context.Books.AsNoTracking().Include(b => b.Author).ToListAsync();

        public async Task<Book> GetBook(Guid id)
            => await _context.Books.AsNoTracking().Include(b=>b.Author).FirstOrDefaultAsync(b => b.Id == id);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
        }
    }
}
