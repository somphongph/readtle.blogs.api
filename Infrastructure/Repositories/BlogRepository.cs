using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Readtle.Blogs.Domain.Interfaces.Repositories;

namespace Readtle.Blogs.Infrastructure.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        Task<PlaceReview> GetItem(string id);
        Task<PlaceReview> GetAll();
        Task<PlaceReview> Create(PlaceReview placeForm);
        Task Update(string id, PlaceReview placeIn);
        Task Delete(string id);
    }
}