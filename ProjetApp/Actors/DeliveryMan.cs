public class DeliveryMan : Person
{
    private String Phone;
    public DeliveryMan(int id, String name, String firstname, String Phone) : base(id, name, firstname)
    {
        this.Phone = Phone;
    }

    public void DeliverOrder(Order order, Bill bill)
    {
        //Deliver one order at a time
        //once the order has been 
        //tell the clerk to update the status of the order
    }
}