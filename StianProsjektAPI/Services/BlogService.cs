using Microsoft.EntityFrameworkCore;
using StianProsjektAPI.Data;
using StianProsjektAPI.Models.Entities;

namespace StianProsjektAPI.Services;

public class BlogService: IBlogService
{
    private ApplicationDbContext db;

    public BlogService(ApplicationDbContext db)
    {
        this.db = db;
    }
    
    public async Task<IEnumerable<Blog>> getAllBlogs()
    {
        var blogs = await db.Blog.Include(b => b.Owner
            )
                .ToListAsync();
        return blogs;
    }

    public async Task<Blog> getBlogById(int id)
    {
        var blog = await db.Blog.FindAsync(id);
        return blog;
    }
}