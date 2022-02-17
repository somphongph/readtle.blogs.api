namespace Readtle.Blogs.Infrastructure.Models
{
    public interface IMongoDbSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}