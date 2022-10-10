public class Clerk : Person
{
    public Clerk(int id, String name, String firstname) : base(id, name, firstname)
    {

    }

    public void Welcome()
    {

    }

    public void TakeOrder(Order order)
    {
        //send Pizzas to Cook 
    } 

    public void GiveOrderToDelivery()
    {

    }
    
    public void updateOrderStatus(Order order){
    
    }
}