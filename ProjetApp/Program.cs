public class Program
{
    public static List<Order> orders = new List<Order>();
    private static Clerk clerk = new Clerk(1,"Truc","Truc");
    private static Cook cook = new Cook(1,"Cook","Cook");
    private static DeliveryMan deliver = new DeliveryMan(1,"New","Deli","0600000000"); 
    public static void Main(String[] args)
    {
        //ACTORS
        List<Customer> customers = getCustomers();
        
        //Start
        foreach(Customer c in customers){
            clerk.Welcome(c);
        }

        Task.Delay(7000).Wait();

    }

    public static List<Customer> getCustomers(){
        

        List<Customer> customers = new List<Customer>();

        Customer client1 = new Customer(1,"Gawinowski","Maya","13 allée de la Licorne","0600000000");
        Customer client2 = new Customer(2,"Dupont","Pauline","13 allée de la Licorne","0600000000");
        Customer client3 = new Customer(3,"Four","Camille","13 allée de la Licorne","0600000000");
        Customer client4 = new Customer(4,"Dupont","Marie","13 allée de la Licorne","0600000000");

        List<Item> list1 = new List<Item>();
        list1.Add(new Pizza(1,EnumTypePizza.Cheese,10));
        list1.Add(new Drink(255,EnumTypeDrink.Cola,5));

        List<Item> list2 = new List<Item>();
        list2.Add(new Pizza(2,EnumTypePizza.Vegetarian,15));
        list2.Add(new Drink(300,EnumTypeDrink.Water,5));

        Order order1 = new Order(1,DateTime.Now,client1,clerk,cook,list1,EnumTypeStatus.in_preparation);
        Order order2 = new Order(2,DateTime.Now,client2,clerk,cook,list2,EnumTypeStatus.in_preparation);

        client1.setOrder(order1);
        client2.setOrder(order2);

        customers.Add(client1);
        customers.Add(client2);
        //customers.Add(client3);
        //customers.Add(client4);
        return customers;
    }
}