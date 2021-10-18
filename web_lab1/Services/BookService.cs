using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_lab1.Entities;

namespace web_lab1.Services
{
    public class BookService
    {
        private readonly DatabaseContext _db;

        public BookService(DatabaseContext db)
        {
            _db = db;
        }

        public Task<List<Book>> GetBooks() => _db.Books.ToListAsync();

        public Task<Book> GetBookWithSages(int id) => _db.Books
            .Include(b => b.Sages)
            .SingleOrDefaultAsync(s => s.Id == id);

        public Task<int> Save(Book book)
        {
            _db.Books.Add(book);
            return _db.SaveChangesAsync();
        }

        public Task<int> Update(Book book)
        {
            var existing = _db.Books.Find(book.Id);
            existing.Name = book.Name;
            existing.Description = book.Description;
            existing.Sages = book.Sages;
            _db.Books.Update(existing);
            return _db.SaveChangesAsync();
        }

        public Task<int> Delete(int id)
        {
            var book = _db.Books.Find(id);
            _db.Books.Remove(book);
            return _db.SaveChangesAsync();
        }

        public Task<List<Book>> GetBooksExcept(IEnumerable<int> ids) => _db.Books
            .Where(b => !ids.Contains(b.Id))
            .ToListAsync();
    }
}