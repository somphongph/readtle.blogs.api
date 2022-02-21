using Readtle.Blogs.Domain.Interfaces;
using Readtle.Blogs.Domain.Entities;
using Readtle.Blogs.Domain.Interfaces.Services;

namespace Readtle.Blogs.Domain.Services
{
    public class BlogService : IBlogService
    {
        private readonly IRepository<Blog> _blogRepository;

        public BlogService(IRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public void Title()
        {

        }
    }
}