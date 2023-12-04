using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StianProsjektAPI.Models.Entities;
using StianProsjektAPI.Models.ViewModels;
using StianProsjektAPI.Services;

namespace StianProsjektAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class BlogController: ControllerBase
{
    private  IBlogService blogService;
    public BlogController(IBlogService blogService)
    {
        this.blogService = blogService;
    }
    
    [HttpGet]
    public Task<IEnumerable<Blog>> Get()
    {
        var blogs = blogService.getAllBlogs();
        return blogs;
    }
    
    [HttpGet("{id}")]
    public Task<Blog> Get(int id)
    {
        var blog = blogService.getBlogById(id);
        return blog;
    }
    
    
}