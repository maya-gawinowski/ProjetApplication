public class Program
{
    public static List<Order> orders = new List<Order>();
    private static List<Clerk> clerks = new List<Clerk>();
    private static Clerk clerk = new Clerk(1,"Truc","Truc");
    private static Cook cook = new Cook(1,"Cook","Cook");
    public static DeliveryMan deliver = new DeliveryMan(1,"New","Deli","0600000000"); 
    public static async Task Main(String[] args)
    {
        //Customer creation
        List<Customer> customers = getCustomers();
        clerk.setDeliverMen(deliver);
        clerks.Add(clerk);

        //Start of the execution
        foreach(Customer c in customers){
            foreach(Clerk clerk in clerks){
                while(clerk.isTaken){

            }
            Thread.Sleep(1000);//customers sleep to show their are slightly calling one after the other
            await Task.Run(() => clerk.Welcome(c));
            }
        }

        Task.Delay(25000).Wait();

    }

    public static List<Customer> getCustomers(){
        List<Customer> customers = new List<Customer>();

        Customer customer1 = new Customer(1,"Gawinowski","Maya","13 allée de la Licorne","0600000000");
        Customer customer2 = new Customer(2,"Dupont","Pauline","13 allée de la Licorne","0600000000");
        Customer customer3 = new Customer(3,"Four","Camille","13 allée de la Licorne","0600000000");
        Customer customer4 = new Customer(4,"Dupont","Marie","13 allée de la Licorne","0600000000");

        List<Item> list1 = new List<Item>();
        list1.Add(new Pizza(1,6,EnumTypePizza.Cheese,10));
        list1.Add(new Pizza(3,2,EnumTypePizza.Margherita,15));
        list1.Add(new Drink(255,EnumTypeDrink.Cola,5));

        List<Item> list2 = new List<Item>();
        list2.Add(new Pizza(2,4,EnumTypePizza.Vegetarian,15));
        list2.Add(new Pizza(2,5,EnumTypePizza.Oriental,15));
        list2.Add(new Pizza(2,6,EnumTypePizza.Vegetarian,15));
        //list2.Add(new Drink(300,EnumTypeDrink.Water,5));

        List<Item> list3 = new List<Item>();
        list3.Add(new Drink(255,EnumTypeDrink.Cola,5));

        List<Item> list4 = new List<Item>();
        list4.Add(new Drink(255,EnumTypeDrink.Cola,5));
        list4.Add(new Pizza(2,2,EnumTypePizza.Vegetarian,15));
        list4.Add(new Pizza(1,3,EnumTypePizza.Cheese,10));
        list4.Add(new Pizza(3,4,EnumTypePizza.Margherita,15));

        Order order1 = new Order(1,DateTime.Now,customer1,clerk,cook,list1,EnumTypeStatus.in_preparation);
        Order order2 = new Order(2,DateTime.Now,customer2,clerk,cook,list2,EnumTypeStatus.in_preparation);
        Order order3 = new Order(3,DateTime.Now,customer3,clerk,cook,list3,EnumTypeStatus.in_preparation);
        Order order4 = new Order(4,DateTime.Now,customer4,clerk,cook,list4,EnumTypeStatus.in_preparation);

        customer1.setOrder(order1);
        customer2.setOrder(order2);
        customer3.setOrder(order3);
        customer4.setOrder(order4);

        customers.Add(customer1);
        customers.Add(customer2);
        customers.Add(customer3);
        customers.Add(customer4);

        customer1.setFlag(1);
        return customers;
    }
}