public class DeliveryMan : Person
{
    private String Phone;
    public DeliveryMan(int id, String name, String firstname, String Phone) : base(id, name, firstname)
    {
        this.Phone = Phone;
    }

    public void DeliverOrder(Order order, Bill bill)
    {
        
    }
}