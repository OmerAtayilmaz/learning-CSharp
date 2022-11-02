namespace Week4_Generics;

public class Product
{
    private int id;
    private String name;

    public Product()
    {
    }

    public Product(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }
    
}