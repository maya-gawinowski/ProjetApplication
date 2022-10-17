public class DeliveryMan : Person
{
    private String Phone;
    public Boolean isindelivery= false;
    public DeliveryMan(int id, String name, String firstname, String Phone) : base(id, name, firstname)
    {
        this.Phone = Phone;
    }

    public void DeliverOrder(Order order, Bill bill)
    {
        //Deliver one order at a time
        //once the order has been 
        //tell the clerk to update the status of the order
        this.isindelivery=true;
        Console.WriteLine("Deliveryman : taking care of order number "+order.getNumber()+" at "+DateTime.Now+"\n");
        Thread.Sleep(4000);
        Console.WriteLine("Deliveryman : order number "+order.getNumber()+" delivered successfully at "+DateTime.Now+"!\n");
        this.isindelivery=false;
    }
}