using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StianProsjektAPI.Data;
using StianProsjektAPI.Models.Entities;

namespace StianProsjektAPI.Services;

public class BlogService: IBlogService
{
    private ApplicationDbContext db;
    
    private UserManager<ApplicationUser> _userManager;

    public BlogService(ApplicationDbContext db, UserManager<ApplicationUser> _userManager)
    {
        this.db = db;
        this._userManager = _userManager;
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

    public async Task SaveBlog(Blog blog, string userName)
    {
        var user = await _userManager.FindByNameAsync(userName);
        blog.Owner = user;
        db.Blog.Add(blog);
        db.SaveChanges();
    }
}