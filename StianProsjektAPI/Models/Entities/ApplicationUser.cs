using Microsoft.AspNetCore.Identity;

namespace StianProsjektAPI.Models.Entities;

public  class ApplicationUser: IdentityUser
{
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
}