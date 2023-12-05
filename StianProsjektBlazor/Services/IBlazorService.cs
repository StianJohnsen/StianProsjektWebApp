namespace StianProsjektBlazor.Services;

public interface IBlazorService
{
    public Task RegisterUser(string userName, string email,string passWord);
}