public class DeliveryMan : Person
{
    private String Phone;
    public Boolean isindelivery= false;
    private List<Order> ordersToDeliver = new List<Order>();
    public DeliveryMan(int id, String name, String firstname, String Phone) : base(id, name, firstname)
    {
        this.Phone = Phone;
    }

    //The deliveryman receives the orders asynchronously
    //but can only take care of one at a time
    //then while he is in delivery he can not deliver other orders
    public async void ReceiveOrder(Order order, Bill bill){
        ordersToDeliver.Add(order);
        while(isindelivery){
        }
        await Task.Run(() => DeliverOrder(order,bill));
    }

    //Deliver one order at a time
    //before delivering updates the status of the order to in delivery
    //once the order has been 
    //then updates the status of the order to deliver
    public void DeliverOrder(Order order, Bill bill)
    {
       
        this.isindelivery=true;
        Console.WriteLine("Deliveryman : taking care of order number "+order.getNumber()+" at "+DateTime.Now+"\n");
        order.setStatus(EnumTypeStatus.in_delivery);
        foreach(Item i in order.getItems()){
            if(i.GetType() == typeof(Drink)){
                Drink d = (Drink) i;
                Console.WriteLine("DeliverMan : Taking drink "+d.getDrink()+" of order "+order.getNumber()+"\n");
                Thread.Sleep(1000);
            }
        }
        Thread.Sleep(4000);
        Console.WriteLine("Deliveryman : order number "+order.getNumber()+" delivered successfully at "+DateTime.Now+"!\n");
        order.setStatus(EnumTypeStatus.closed);
        this.isindelivery=false;
    }
}