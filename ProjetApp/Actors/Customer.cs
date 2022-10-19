

public class Customer : Person
{
    private String Address;
    private String Phone;
    public Order order;
    private int flag;
    public Customer(int id, String name, String firstname, String Address, String Phone) : base(id, name, firstname)
    {
        this.Address = Address;
        this.Phone = Phone;
    }

    //Async because customers can browse the menu at the same time
    //Once they are done, they are calling back the clerk
    public void BrowseMenu(Clerk c)
    {
        Console.WriteLine("Customer : "+getFullName());
        Console.WriteLine("Thank you I will choose\n");
        Thread.Sleep(3000);
        Console.WriteLine("Customer : "+getFullName()+" calling back !\n");
    }

    public String getAddress(){
        return this.Address;
    }

    public void setOrder(Order order){
        this.order=order;
    }

    public Order getOrder(){
        return this.order;
    }

    public int getFlag(){
        return this.flag;
    }

    public void setFlag(int f){
        this.flag=f;
    }
}