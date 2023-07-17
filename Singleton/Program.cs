using Singleton;

SingletonClass.GetInstance().PrintDateTime();
Thread.Sleep(2000);
SingletonThreadSafeClass.GetInstance().PrintDateTime();
SingletonClass.GetInstance().PrintDateTime();
Thread.Sleep(2000);
SingletonThreadSafeClass.GetInstance().PrintDateTime();
