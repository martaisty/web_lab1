using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_lab1.Entities;

namespace web_lab1.Services
{
    public class SageService
    {
        private readonly DatabaseContext _db;

        public SageService(DatabaseContext db)
        {
            _db = db;
        }

        public Task<List<Sage>> GetSages() => _db.Sages.ToListAsync();

        public Task<Sage> GetSageWithBooks(int id) => _db.Sages
            .Include(s => s.Books)
            .SingleOrDefaultAsync(b => b.Id == id);

        public Task<int> Save(Sage sage)
        {
            _db.Sages.Add(sage);
            return _db.SaveChangesAsync();
        }

        public Task<int> Update(Sage sage)
        {
            var existing = _db.Sages.Find(sage.Id);
            existing.Name = sage.Name;
            existing.Age = sage.Age;
            existing.Photo = sage.Photo;
            existing.City = sage.City;
            existing.Books = sage.Books;
            _db.Sages.Update(existing);
            return _db.SaveChangesAsync();
        }

        public Task<int> Delete(int id)
        {
            var sage = _db.Sages.Find(id);
            _db.Sages.Remove(sage);
            return _db.SaveChangesAsync();
        }

        public Task<List<Sage>> GetSagesExcept(IEnumerable<int> ids) => _db.Sages
            .Where(s => !ids.Contains(s.Id))
            .ToListAsync();
    }
}