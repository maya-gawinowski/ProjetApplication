public class Customer : Person
{
    private String Address;
    private String Phone;
    public Customer(int id, String name, String firstname, String Address, String Phone) : base(id, name, firstname)
    {
        this.Address = Address;
        this.Phone = Phone;
    }

    //not async because only one customer can get the Clerk at a time
    public void callRestaurant(){
        //calling restaurant
    }

    //Async because customers can browse the menu at the same time
    public async Order BrowseMenu()
    {
        //choose items in menu
        //return the order of the customer order
    }
}