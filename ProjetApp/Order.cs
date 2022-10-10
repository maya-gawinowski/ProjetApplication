public class Order
{
    private int NbOrder;
    private DateTime time;
    private Customer customer;
    private Clerk clerk;
    private List<Item> items;
    private EnumTypeStatus status;
    public Order(int NbOrder, DateTime time, Customer customer, Clerk clerk, List<Item> items, EnumTypeStatus status)
    {
        this.NbOrder = NbOrder;
        this.time = time;
        this.customer = customer;
        this.clerk = clerk;
        this.items = items;
        this.status = status;
    }
}