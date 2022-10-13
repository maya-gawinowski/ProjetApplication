public class Person
{
    private int id;
    private String name;
    private String firstname;
    public String linefiller = "-------------------------";

    public Person(int id, String name, String firstname)
    {
        this.id=id;
        this.name = name;
        this.firstname = firstname;
    }

    public String getFullName(){
        return this.firstname+" "+this.name;
    }
}