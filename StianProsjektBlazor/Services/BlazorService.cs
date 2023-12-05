using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using StianProsjektAPI.Models.Entities;
using StianProsjektAPI.Models.ViewModels;

namespace StianProsjektBlazor.Services;

public class BlazorService: IBlazorService
{
    private readonly HttpClient _httpClient;
    private IJSRuntime _jsRuntime;
    public BlazorService(HttpClient httpClient, IJSRuntime jsRuntime)
    {
        _httpClient = httpClient;
        _jsRuntime = jsRuntime;
    }


    
    public async Task RegisterUser(String userName, String eMail,String passWord)
    {
        var user = new RegisterViewModel
        {
            Username = userName,
            Email = eMail,
            Password = passWord
        };
        
        var respons = await _httpClient.PostAsJsonAsync("https://localhost:7241/api/Authenticate/register",user);
        if (respons.IsSuccessStatusCode)
        {
            Console.WriteLine("User registered sucessfully");
            
        }
        else
        {
            Console.WriteLine("User registration failed");
        }

    }
    
    public async Task LoginUser(String userName, String passWord)
    {
        var user = new LoginViewModel
        {
            Username = userName,
            Password = passWord
        };
        
        var respons = await _httpClient.PostAsJsonAsync("https://localhost:7241/api/Authenticate/login",user);
        if (respons.IsSuccessStatusCode)
        {
            var jsonResponse = await respons.Content.ReadAsStringAsync();
            Console.WriteLine(jsonResponse);

            var tokenResponse = JsonConvert.DeserializeObject<testJsonObject>(jsonResponse);

            if (tokenResponse != null)
            {
                Console.WriteLine("User logged in sucessfully, Token: " + tokenResponse.Token);
                _jsRuntime.InvokeVoidAsync("localStorage.setItem", "authToken", tokenResponse.Token);

            }
            else
            {
                Console.WriteLine("Failed to deserialize token");
            }

            
        }
        else
        {
            Console.WriteLine("User login failed");
        }

    }
}

class testJsonObject
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public DateTime Expiration { get; set; }
}