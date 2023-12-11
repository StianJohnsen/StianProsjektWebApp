namespace StianProsjektAPI.Models.ViewModels;

public class LoginResponse
{
public string token { get; set; }
public string refreshToken { get; set; }
public string expiration { get; set; }
public bool success { get; set; }

}