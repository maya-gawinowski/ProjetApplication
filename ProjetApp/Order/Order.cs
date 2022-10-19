public class Order
{
    private int NbOrder;
    private DateTime time;
    private Customer customer;
    private Clerk clerk;
    private Cook cook;
    private List<Item> items;
    private EnumTypeStatus status;
    public Order(int NbOrder, DateTime time, Customer customer, Clerk clerk,Cook cook, List<Item> items, EnumTypeStatus status)
    {
        this.NbOrder = NbOrder;
        this.time = time;
        this.customer = customer;
        this.clerk = clerk;
        this.items = items;
        this.status = status;
        this.cook=cook;
    }

    public override String ToString(){
        return "Order number : "+this.NbOrder+ " - made at : "+this.time;
    }

    public Cook getCook(){
        return this.cook;
    }

    public Clerk getClerk(){
        return this.clerk;
    }

    public int getNumber(){
        return this.NbOrder;
    }

    public double getFullPrice(){
        double total=0;
        foreach(Item item in items){
            total+=item.getPrice();
        }
        return total;
    }

    public List<Item> getItems(){
        return this.items;
    }

    public void setStatus(EnumTypeStatus e){
        this.status=e;
    }
    
}