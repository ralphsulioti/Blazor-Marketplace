public class Listing {
    // Could also add a categories data member 
    // and include a drop down in HTML such that the user has to 
    // select from predeclared ones
    
    public int id {get; set;}
    public string name {get; set;}
    public int price {get; set;}

    public Listing() {
        name = "";
        price = 0;
    }

    public Listing(int ID, string Name, int Price) {
        id = ID;
        name = Name;
        price = Price;
    }
}