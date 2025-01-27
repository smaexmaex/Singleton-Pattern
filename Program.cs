using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            s1.DoSomething();
            s1.PrintMemoryAddress();

            Singleton s2 = Singleton.Instance;
            s2.DoSomething();
            s2.PrintMemoryAddress();

            Console.WriteLine(ReferenceEquals(s1, s2)); // True
        }
    }
}
