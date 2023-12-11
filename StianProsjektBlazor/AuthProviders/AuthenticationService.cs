using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using StianProsjektAPI.Models.Entities;
using StianProsjektAPI.Models.ViewModels;

namespace StianProsjektBlazor.AuthProviders;

public class AuthenticationService: IAuthenticationService
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _serializerOptions;
    private readonly AuthenticationStateProvider _authStateProvider;
    private readonly ILocalStorageService _localStorage;
    
    public AuthenticationService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider, ILocalStorageService localStorage)
    {
        _httpClient = httpClient;
        _authStateProvider = authenticationStateProvider;
        _localStorage = localStorage;
        _serializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }
    
    public async Task<LoginResponse> Login(LoginViewModel loginViewModel)
    {
        var authResult = await _httpClient.PostAsJsonAsync("https://localhost:7241/api/Authenticate/login", loginViewModel);
        var authContent = await authResult.Content.ReadAsStringAsync();

        var jsonAuthContent = JsonSerializer.Deserialize<LoginResponse>(authContent, _serializerOptions);

        if (!authResult.IsSuccessStatusCode)
        {
            return jsonAuthContent;
        }
        await _localStorage.SetItemAsync("authToken", jsonAuthContent.token);
        ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(loginViewModel.Username);
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", jsonAuthContent.token);
        
        
        return jsonAuthContent;

    }
    
        public async Task<RegisterResponse> RegisterUser(RegisterViewModel registerViewModel)
        {
            var authResult = await _httpClient.PostAsJsonAsync("https://localhost:7241/api/Authenticate/register", registerViewModel);
            var authContent = await authResult.Content.ReadAsStringAsync();

            var jsonAuthContent = JsonSerializer.Deserialize<RegisterResponse>(authContent, _serializerOptions);
            return jsonAuthContent;
        }
     



    public async Task Logout()
    {
        await _localStorage.RemoveItemAsync("authToken");
        ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
        _httpClient.DefaultRequestHeaders.Authorization = null;
    }
    
}

public class JsonResponse
{
    public string Token { get; set; }
    public string Message { get; set; }
    public bool isAuthSuccessful { get; set; }
    
}