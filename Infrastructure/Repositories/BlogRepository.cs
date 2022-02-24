using MongoDB.Driver;
using Readtle.Blogs.Domain.Entities;
using Readtle.Blogs.Domain.Interfaces.Repositories;
using Readtle.Blogs.Infrastructure.Models;

namespace Readtle.Blogs.Infrastructure.Repositories
{
    public class BlogRepository : IBaseRepository<Blog>
    {
        private readonly IMongoCollection<Blog> _blogs;

        public BlogRepository(IMongoDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _blogs = database.GetCollection<Blog>("Blogs");
        }

        public async Task<Blog> GetItem(string id)
        {
            return await _blogs
               .Find(b => b.Id == id)
               .FirstOrDefaultAsync();
        }

        public async Task<List<Blog>> GetAll()
        {
            return await _blogs
                .Find(_ => true)
                .ToListAsync();
        }

        public async Task<Blog> Create(Blog blog)
        {
            // var userId = _accessor?.HttpContext.User.FindFirst(ClaimTypes.Sid).Value;

            // Update PlaceReview
            blog.CreatedBy = "userId";
            blog.CreatedOn = DateTime.Now;
            await _blogs.InsertOneAsync(blog);

            return blog;
        }

        public async Task Update(string id, Blog blog)
        {
            await _blogs.ReplaceOneAsync(placeReview => placeReview.Id == id, blog);
        }

        public async Task Delete(string id)
        {
            await _blogs.DeleteOneAsync(placeReview => placeReview.Id == id);
        }

    }
}