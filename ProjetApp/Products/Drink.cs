public class Drink : Item
{
    private int volume;
    private EnumTypeDrink drink;
    public Drink(int volume, EnumTypeDrink drink, double price) : base(price)
    {
        this.volume = volume;
        this.drink = drink;
    }

    public EnumTypeDrink getDrink(){
        return this.drink;
    }
}