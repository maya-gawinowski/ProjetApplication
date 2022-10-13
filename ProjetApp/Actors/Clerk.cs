public class Clerk : Person
{
    public Clerk(int id, String name, String firstname) : base(id, name, firstname)
    {

    }

    public async void Welcome(Customer c)
    {
        //Greets customers (one at a time)
        //Give them the menu
        Console.WriteLine(linefiller);
        Console.WriteLine("Welcome customer "+c.getFullName());
        Console.WriteLine("You can take a few minutes to choose your order. Here is the menu");
        await Task.Run(() => c.BrowseMenu());
        TakeOrder(c);
    }

    public async void TakeOrder(Customer c)
    {
        //Receives the order from the customer (one at a time)
        //send Pizzas to Cook 
        Console.WriteLine(linefiller);
        Console.WriteLine("Welcome back customer "+c.getFullName());
        Console.WriteLine("Tell me your order");
        //Console.WriteLine(c.getOrder());
        Order order = c.getOrder();
        Console.WriteLine("Clerk : Thank you I will send your order to the kitchen");
        await Task.Run(() => order.getCook().ReceiveOrder(order));
    } 

    public void GiveOrderToDelivery()
    {
        //Give the ready to deliver order with pizza given by the cook
        //give the coordinates of the customer to the deliveryman
        //gives the bill to the deliveryman
    }
    
    public void updateOrderStatus(Order order){
        //Change the status to in preparation when the order has been taken 
        //change status to in delivery when the order has been given to the deliveryman
        //change status to closed when the deliveryman has confirmed the delivery
    }
}