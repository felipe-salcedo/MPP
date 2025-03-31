public interface Prototype
{
    public void DisplayInfo();
    public Prototype clone();
}

class Person : Prototype
{
    public string name;
    public int age;
    public string hairColor;

    public double height;

    public Person(string name, int app, string hairColor, double height)
    {
        this.name = name;
        this.age = age;
        this.hairColor = hairColor;
        this.height = height;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine("\n------- Informações do sujeito da pesquisa --------");
        System.Console.WriteLine($"Nome: {this.name}" +
        $"\nIdade: {this.age}" +
        $"\nCor Do Cabelo: {this.hairColor}" +
        $"\nAltura: {this.height}");
    }

    public Prototype clone()
    {
        return new Person(this.name, this.age, this.hairColor, height);
    }
}

class secondaryProgram
{
    public Prototype getPerson()
    {
        return new Person("Azarado 2", 17, "Castanho", 1.72);
    }
}

class Program
{
    static void Main()
    {
        secondaryProgram secProg = new secondaryProgram();
        Prototype person1 = secProg.getPerson();
        person1.DisplayInfo();

        Prototype person2 = person1.clone();
        person2.DisplayInfo();

        Prototype person3 = person1.clone();
        person3.DisplayInfo();
    }
}