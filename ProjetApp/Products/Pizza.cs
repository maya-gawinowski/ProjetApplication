public class Pizza : Item
{
    private int size;
    private EnumTypePizza pizza;
    public Pizza(int size, EnumTypePizza pizza, double price) : base(price)
    {
        this.size = size;
        this.pizza = pizza;
    }

    public EnumTypePizza getPizzaType(){
        return this.pizza;
    }
}