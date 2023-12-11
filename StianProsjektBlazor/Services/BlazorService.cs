using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using NuGet.Common;
using StianProsjektAPI.Models.Entities;
using StianProsjektAPI.Models.ViewModels;

namespace StianProsjektBlazor.Services;


public class BlazorService : IBlazorService
{
    private readonly HttpClient _httpClient;
    private readonly ILocalStorageService _localStorage;

    public BlazorService(HttpClient httpClient, ILocalStorageService localStorage)
    {
        _httpClient = httpClient;
        _localStorage = localStorage;

    }


    


    

    /*public async Task RefreshToken(string token, string refreshToken)
    {
        var tokenModel = new TokenModel
        {
            AccessToken = token,
            RefreshToken = refreshToken
        };
        var response = await _httpClient.PostAsJsonAsync("https://localhost:7241/api/Authenticate/refresh-token", tokenModel);
        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var tokenResponse = JsonConvert.DeserializeObject<testJsonObject>(jsonResponse);
            if (tokenResponse != null)
            {
                Console.WriteLine("Token refreshed sucessfully, Token: " + tokenResponse.Token);
                _jsRuntime.InvokeVoidAsync("localStorage.setItem", "authToken", tokenResponse.Token);
                _jsRuntime.InvokeVoidAsync("localStorage.setItem", "refreshToken", tokenResponse.RefreshToken);
            }
            else
            {
                Console.WriteLine("Failed to deserialize token");
            }
        }
    }*/
    
    public async Task CreateBlog(BlogViewModel blogViewModel, string userName)
    {
        var response = await _httpClient.PostAsJsonAsync("https://localhost:7241/api/Blog", blogViewModel);
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Blog created sucessfully");
        }
        else
        {
            Console.WriteLine("Failed to create blog");
        }
    }

    public IEnumerable<Blog> GetAllBlogs()
    {
        Console.WriteLine(_localStorage.GetItemAsync<string>("authToken"));
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _localStorage.GetItemAsync<string>("authToken").Result);
        var response = _httpClient.GetAsync("https://localhost:7241/api/Blog").Result;
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Got the blogs");
            var jsonResponse = response.Content.ReadAsStringAsync().Result;
            var blogs = JsonConvert.DeserializeObject<IEnumerable<Blog>>(jsonResponse);
            return blogs;
        }
        else
        {
            Console.WriteLine("Failed to get blogs");
            return null;
        }

    }


}

class testJsonObject
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public DateTime Expiration { get; set; }
}