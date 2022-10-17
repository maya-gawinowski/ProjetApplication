public class Cook : Person
{
    public Cook(int id, String name, String firstname) : base(id, name, firstname)
    {
    }

    public async void ReceiveOrder(Order order)
    {
        Console.WriteLine("Cook : received order number : "+order.getNumber());
        List<Pizza> pizzas = new List<Pizza>();
        foreach(Item i in order.getItems()){
            if(i.GetType() == typeof(Pizza)){
                pizzas.Add((Pizza) i);
            }
        }
        //Takes all pizzas from the order and execute their making 
        //several pizza can be made at the same time
        foreach(Pizza p in pizzas){
            await Task.Run(() => MakePizza(p,order.getNumber()));
        }
        Console.WriteLine("Cook : Command number : "+order.getNumber()+" ready to deliver ! \n");
        order.getClerk().GiveOrderToDelivery(order);
    }

    public async void MakePizza(Pizza pizza, int number)
    {
        //preparation of a pizza
        Console.WriteLine("Cook : making pizza "+pizza.getPizzaType()+" of order : "+number+"\n");
        Thread.Sleep(pizza.getSize()*1000);
        Console.WriteLine("Cook : pizza "+pizza.getPizzaType()+" ready !\n");
    }
}