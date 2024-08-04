public class AuthStatus
{
    public bool IsAuthenticated { get; set; } = false;
    public User currUser {get; set; }

    public void Login()
    {
        IsAuthenticated = true;
    }

    public void Logout()
    {
        IsAuthenticated = false;
        currUser = null;
    }
}
