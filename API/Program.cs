using Microsoft.Extensions.Options;
using Readtle.Blogs.Domain.Interfaces.Repositories;
using Readtle.Blogs.Domain.Interfaces.Services;
using Readtle.Blogs.Domain.Entities;
using Readtle.Blogs.Domain.Services;
using Readtle.Blogs.Infrastructure.Models;
using Readtle.Blogs.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region MongoDB
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddSingleton<IMongoDbSettings>(sp =>
    sp.GetRequiredService<IOptions<MongoDbSettings>>().Value);
#endregion

#region Services dependency injection
builder.Services.AddScoped<IBlogService, BlogService>();
#endregion

#region Repositories dependency injection
builder.Services.AddSingleton<IBaseRepository<Blog>, BlogRepository>();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
