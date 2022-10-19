public class Pizza : Item
{
    private int size;
    private EnumTypePizza pizza;
    private int amountOfIngredient;
    public Pizza(int size,int ingredients, EnumTypePizza pizza, double price) : base(price)
    {
        this.size = size;
        this.pizza = pizza;
        this.amountOfIngredient=ingredients;
    }

    public EnumTypePizza getPizzaType(){
        return this.pizza;
    }

    public int getSize(){
        return this.size;
    }

    public int getAmountIngredients(){
        return this.amountOfIngredient;
    }
}