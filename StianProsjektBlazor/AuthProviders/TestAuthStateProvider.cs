using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace StianProsjektBlazor.AuthProviders;

public class TestAuthStateProvider : AuthenticationStateProvider
{
    public async override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        await Task.Delay(1500);
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, "Stian"),
            new Claim(ClaimTypes.Role, "Administrator")
        };
        var anonymous = new ClaimsIdentity(claims, "TestAuthType");
        return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
    }
}