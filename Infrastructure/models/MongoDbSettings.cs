namespace Readtle.Blogs.Infrastructure.Models
{
    public class MongoDbSettings : IMongoDbSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}