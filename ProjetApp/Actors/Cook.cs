public class Cook : Person
{
    public Cook(int id, String name, String firstname) : base(id, name, firstname)
    {
    }

    public async void ReceiveOrder(Order order)
    {
        Console.WriteLine(linefiller);
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
            await Task.Run(() => MakePizza(p));
        }
    }

    public async void MakePizza(Pizza pizza)
    {
        //preparation of a pizza
        Console.WriteLine(linefiller);
        Console.WriteLine("Cook : making pizza "+pizza.getPizzaType());
        Thread.Sleep(5000);
        Console.WriteLine("Cook : pizza "+pizza.getPizzaType()+" ready !");
    }
}