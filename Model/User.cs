using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Users")]
public class User {
    [Key]
    public int id {get; set; }
    [Required]
    public string username {get; set; }
    [Required]
    public string password {get; set; }
    [Required]
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