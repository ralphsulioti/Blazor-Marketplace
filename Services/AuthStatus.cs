public class AuthStatus
{
    public bool IsAuthenticated { get; set; } = false;

    public void Login()
    {
        IsAuthenticated = true;
    }

    public void Logout()
    {
        IsAuthenticated = false;
    }
}
