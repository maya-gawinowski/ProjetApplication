

public class Customer : Person
{
    private String Address;
    private String Phone;
    Order order;
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
    public void BrowseMenu()
    {
        //choose items in menu
        //return the order of the customer order
        chooseOrder();
        //await Task.Run(() => chooseOrder());
    }

    public void chooseOrder(){
        Console.WriteLine(linefiller);
        Console.WriteLine("Customer : "+getFullName());
        Console.WriteLine("Thank you I will choose");
        Thread.Sleep(3000);
        Console.WriteLine("I have made my choice");
    }

    public void setOrder(Order order){
        this.order=order;
    }

    public Order getOrder(){
        return this.order;
    }
}