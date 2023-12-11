using StianProsjektAPI.Models.Entities;
using StianProsjektAPI.Models.ViewModels;

namespace StianProsjektBlazor.AuthProviders;

public interface IAuthenticationService
{
    Task<LoginResponse> Login(LoginViewModel loginViewModel);
    //Task<Response> RegisterUser(RegisterViewModel registerViewModel);
    Task Logout();
    public Task<RegisterResponse> RegisterUser(RegisterViewModel registerViewModel);


}