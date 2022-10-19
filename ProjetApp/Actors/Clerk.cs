public class Clerk : Person
{

    public List<DeliveryMan> deliveryMen = new List<DeliveryMan>();
    public Boolean isTaken=false;
    public List<Customer> customers = new List<Customer>();

    public Clerk(int id, String name, String firstname) : base(id, name, firstname)
    {

    }

    //Greets customers (one at a time)
    //Give them the menu
    public async void Welcome(Customer c)
    {
        
        isTaken=true;
        if(c.getFlag()==1){
            Console.WriteLine("Welcome back "+c.getFullName());
        }
        else{
            Console.WriteLine("I see you are a new customer "+c.getFullName()+", I will just take your infos: "+c.getAddress());
            c.setFlag(1);
        }

        Console.WriteLine("Clerk : You can take a few minutes to choose your order. Here is the menu\n");
        isTaken=false;
        await Task.Run(() => c.BrowseMenu(this));
        TakeOrder(c);
    }

    public void setDeliverMen(DeliveryMan dm){
        deliveryMen.Add(dm);
    }

    //Receives the order from the customer (one at a time)
    //send the Order to the Cook 
    public void TakeOrder(Customer c)
    {
        Order order = c.getOrder();
        isTaken=true;
        Console.WriteLine("Clerk : Welcome back customer "+c.getFullName());
        Console.WriteLine("Clerk : Tell me your order");        
        Console.WriteLine("Clerk : Thank you I will send your order to the kitchen\n");
        order.getCook().ReceiveOrder(order);
        isTaken=false;
    } 

    //Give the ready to deliver order with pizza given by the cook
    //give the coordinates of the customer to the deliveryman
    //gives the bill to the deliveryman
    public void GiveOrderToDelivery(Order order)
    {
        Console.WriteLine("Clerk : sending order number "+order.getNumber()+" in delivery \n");
        foreach(DeliveryMan dl in deliveryMen){
            dl.ReceiveOrder(order,new Bill(order.getFullPrice()));
        }
    }
}