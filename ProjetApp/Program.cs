public class Program
{
    public static void Main(String[] args)
    {
        //ACTORS
        
        List<Customer> customers = getCustomers();
        Clerk clerk = new Clerk(1,"Truc","Truc");
        Cook cook = new Cook(1,"Cook","Cook");
        DeliveryMan deliver = new DeliveryMan(1,"New","Deli","0600000000");
    }

    public static List<Customer> getCustomers(){
        List<Customer> customers = new List<Customer>();
        Customer client1 = new Customer(1,"Gawinowski","Maya","13 allée de la Licorne","0600000000");
        Customer client2 = new Customer(2,"Dupont","Pauline","13 allée de la Licorne","0600000000");
        Customer client3 = new Customer(3,"Four","Camille","13 allée de la Licorne","0600000000");
        Customer client4 = new Customer(4,"Dupont","Marie","13 allée de la Licorne","0600000000");
        customers.Add(client1);
        customers.Add(client2);
        customers.Add(client3);
        customers.Add(client4);
        return customers;
    }
}