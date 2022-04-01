using Books.Api.Entites;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.Api.Repositories
{
    public interface IBooksRepository
    {
        Task<Book> GetBook(Guid id);
        Task<IEnumerable<Book>> GetBooks();
    }
}