public class Customer : Person
{
    private String Address;
    private String Phone;
    public Customer(String name, String firstname, String Address, String Phone) : base(name, firstname)
    {
        this.Address = Address;
        this.Phone = Phone;
    }
}