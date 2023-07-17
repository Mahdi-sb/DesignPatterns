namespace Singleton;
public class SingletonThreadSafeClass
{
    private SingletonThreadSafeClass()
    {
        DateTime = DateTime.Now;
    }

    public DateTime DateTime { get; }
    private static object _locker = new();
    private static SingletonThreadSafeClass _instance;

    public static SingletonThreadSafeClass GetInstance()
    {

        if (_instance == null)
        {
            lock (_locker)
            {
                _instance ??= new SingletonThreadSafeClass();
            }
        }
        return _instance;
    }

    public void PrintDateTime() => Console.WriteLine(DateTime);
}
