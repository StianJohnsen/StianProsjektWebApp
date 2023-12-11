using StianProsjektAPI.Models.Entities;

namespace StianProsjektBlazor.Services;

public interface IBlazorService
{
    
    //public Task RefreshToken(string token, string refreshToken);

    public IEnumerable<Blog> GetAllBlogs();
}