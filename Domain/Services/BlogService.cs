using Readtle.Blogs.Domain.Entities;
using Readtle.Blogs.Domain.Interfaces.Services;
using Readtle.Blogs.Domain.Interfaces.Repositories;

namespace Readtle.Blogs.Domain.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBaseRepository<Blog> _blogRepository;

        public BlogService(IBaseRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public void Title()
        {

        }
    }
}