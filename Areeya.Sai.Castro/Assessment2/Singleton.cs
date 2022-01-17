public interface ISingletonContainer
{
    string GetCapital(string name);
}

public class SingletonDataContainer : ISingletonContainer
{
    private Dictionary<string, string> _country = new Dictionary<string, string>();
    private SingletonDataContainer()
    {
        Console.WriteLine("Initializing singleton object");
        var elements = File.ReadAllLines("countries.txt");
        var x = elements.Length;
        for (int i = 0; i < elements.Length; i += 2)
        {
            _country.Add(elements[i], elements[i + 1]);
        }
    }
    public string GetCapital(string name)
    {
        return _country[name];
    }
    private static Lazy<SingletonDataContainer> instance = new Lazy<SingletonDataContainer>(() => new SingletonDataContainer());
    public static SingletonDataContainer Instance => instance.Value;
}

class Program
{
    static void Main(string[] args)
    {
        var db = SingletonDataContainer.Instance;
        Console.WriteLine(db.GetCapital("Philippines"));
        var db2 = SingletonDataContainer.Instance;
        Console.WriteLine(db2.GetCapital("Japan"));
        var db3 = SingletonDataContainer.Instance;
        Console.WriteLine(db2.GetCapital("South Korea"));
    }
}