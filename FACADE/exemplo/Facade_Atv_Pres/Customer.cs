/// Classe para o Cliente

public class Customer
{
    private string name;

    // Construtor para repassar os dados do Cliente

    public Customer(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }
}
