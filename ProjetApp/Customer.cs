public class Customer : Person
{
    private String Address;
    private String Phone;
    public Customer(int id, String name, String firstname, String Address, String Phone) : base(id, name, firstname)
    {
        this.Address = Address;
        this.Phone = Phone;
    }

    public void callRestaurant(){
        //calling restaurant
        //
    }

    public async void BrowseMenu()
    {
        //choose items in menu
        //return order ?
    }
}