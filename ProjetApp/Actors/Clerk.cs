public class Clerk : Person
{
    public Clerk(int id, String name, String firstname) : base(id, name, firstname)
    {

    }

    public void Welcome()
    {
        //Greets customers (one at a time)
        //Give them the menu
    }

    public void TakeOrder(Order order)
    {
        //Receives the order from the customer (one at a time)
        //send Pizzas to Cook 
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