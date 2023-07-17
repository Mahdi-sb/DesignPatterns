namespace Singleton;
public class SingletonClass
{
    public DateTime DateTime { get; set; }
    private SingletonClass() { }

    private static SingletonClass _instance;

    public static SingletonClass GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SingletonClass { DateTime = DateTime.Now };
        }
        return _instance;
    }

    public void PrintDateTime() => Console.WriteLine(DateTime);
}