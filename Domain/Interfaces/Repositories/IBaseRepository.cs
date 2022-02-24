namespace Readtle.Blogs.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<T> GetItem(string id);
        Task<List<T>> GetAll();
        Task<T> Create(T blog);
        Task Update(string id, T blog);
        Task Delete(string id);
    }
}