public class Cook : Person
{
    public Cook(int id, String name, String firstname) : base(id, name, firstname)
    {
    }

    //Takes all pizzas from the order and execute their making 
    //several pizza can be made at the same time
    public async void ReceiveOrder(Order order)
    {
        Console.WriteLine("Cook : received order number : "+order.getNumber());
        List<Pizza> pizzas = new List<Pizza>();
        //gets only the pizza from the delivery to make them
        foreach(Item i in order.getItems()){
            if(i.GetType() == typeof(Pizza)){
                pizzas.Add((Pizza) i);
            }
        }
        
        //make the pizzas and awaits all are done to keep on executing the code
        foreach(Pizza p in pizzas){
            await Task.Run(() => MakePizza(p,order.getNumber()));
        }
        //once all pizzas of one order are completed, the deliveryman gives back the order to the clerk
        Console.WriteLine("Cook : Command number : "+order.getNumber()+" ready to deliver ! at "+DateTime.Now+" \n");
        order.getClerk().GiveOrderToDelivery(order);
    }

    //The time a pizza takes to be made depends on the amount of ingredient it contains
    public void MakePizza(Pizza pizza, int number)
    {
        Console.WriteLine("Cook : making pizza "+pizza.getPizzaType()+" of order : "+number+"\n");
        int i=pizza.getAmountIngredients();
        while(i>0){
            Thread.Sleep(1000);
            i--;
        }
        Console.WriteLine("Cook : pizza "+pizza.getPizzaType()+" ready !\n");
    }
}