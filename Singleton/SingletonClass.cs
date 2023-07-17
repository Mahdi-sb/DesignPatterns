namespace Singleton;
public class SingletonClass
{
    public DateTime DateTime { get; }

    private SingletonClass()
    {
        DateTime = DateTime.Now;
    }

    private static SingletonClass _instance;

    public static SingletonClass GetInstance()
    {
        return _instance ??= new SingletonClass();
    }

    public void PrintDateTime() => Console.WriteLine(DateTime);
}