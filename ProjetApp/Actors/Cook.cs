public class Cook : Person
{
    public Cook(int id, String name, String firstname) : base(id, name, firstname)
    {
    }

    public async void ReceiveOrder(List<Pizza> pizzas)
    {
        //Takes all pizzas from the order and execute their making 
        //several pizza can be made at the same time
    }

    public void MakePizza(Pizza pizza)
    {
        //preparation of a pizza
    }
}