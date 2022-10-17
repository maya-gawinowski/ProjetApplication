public class Clerk : Person
{

    public List<DeliveryMan> deliveryMen = new List<DeliveryMan>();
    public Boolean isTaken=false;

    public Clerk(int id, String name, String firstname) : base(id, name, firstname)
    {

    }

    public async void Welcome(Customer c)
    {
        //Greets customers (one at a time)
        //Give them the menu
        isTaken=true;
        Console.WriteLine("Welcome customer "+c.getFullName());
        await Task.Run(() => giveMenu(c));
        TakeOrder(c);
    }

    public void giveMenu(Customer c){
        Console.WriteLine("Clerk : You can take a few minutes to choose your order. Here is the menu\n");
        isTaken=false;
        c.BrowseMenu(this);
    }

    public void setDeliverMen(DeliveryMan dm){
        deliveryMen.Add(dm);
    }

    public async void TakeOrder(Customer c)
    {
        //Receives the order from the customer (one at a time)
        //send Pizzas to Cook 
        Order order = c.getOrder();
        isTaken=true;
        Console.WriteLine("Clerk : Welcome back customer "+c.getFullName());
        Console.WriteLine("Clerk : Tell me your order");        
        Console.WriteLine("Clerk : Thank you I will send your order to the kitchen\n");
        isTaken=false;
        await Task.Run(() => order.getCook().ReceiveOrder(order));
    } 

    public void GiveOrderToDelivery(Order order)
    {
        //Give the ready to deliver order with pizza given by the cook
        //give the coordinates of the customer to the deliveryman
        //gives the bill to the deliveryman
        Console.WriteLine("Clerk : sending order number "+order.getNumber()+" in delivery \n");
        foreach(DeliveryMan dl in deliveryMen){
            while(dl.isindelivery){
            }
            dl.DeliverOrder(order,new Bill(order.getFullPrice()));
        }
    }
    
    public void updateOrderStatus(Order order){
        //Change the status to in preparation when the order has been taken 
        //change status to in delivery when the order has been given to the deliveryman
        //change status to closed when the deliveryman has confirmed the delivery
    }
}