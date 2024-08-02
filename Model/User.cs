public class User {

    public int id {get; set; }
    public string username {get; set; }
    public string password {get; set; }
    public string email {get; set; }

    public User() {
        username = "";
        password = "";
        email = "";
    }

    public User(int ID, string Name, string Password, string Email) {
        id = ID;
        username = Name;
        password = Password;
        email = Email;
    }
}