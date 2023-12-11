using StianProsjektAPI.Models.Entities;

namespace StianProsjektAPI.Services;

public interface IBlogService
{
    Task<IEnumerable<Blog>> getAllBlogs();
    Task<Blog> getBlogById(int id);
    
    Task SaveBlog(Blog blog, string userName);
    
}