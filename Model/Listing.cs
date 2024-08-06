using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Listing {
    // Could also add a categories data member 
    // and include a drop down in HTML such that the user has to 
    // select from predeclared ones
    
    public int id {get; set;}
    public string name {get; set;}
    public int price {get; set;}
    [Required]
    public User user {get; set;}
    [Required]
    public string category {get; set; }

    public Listing() {
        name = "";
        price = 0;
        user = null;
        category = "";
    }

    public Listing(int ID, string Name, int Price, User User, string Category) {
        id = ID;
        name = Name;
        price = Price;
        user = User;
        category = Category;
    }
}