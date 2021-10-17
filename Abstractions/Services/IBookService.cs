namespace Abstractions.Services
{
    public interface IBookService
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> GetByIdAsync(TKey id);

        Task InsertAsync(Book entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteById(TKey id);
    }
}