using Proxy;
using System;

class Program
{
    static void Main(string[] args)
    {
        ISubject proxy = null;
        bool runProgram = true;

        while (runProgram)
        {
            Console.WriteLine("Choose a Proxy Implementation:");
            Console.WriteLine("1. Virtual Proxy");
            Console.WriteLine("2. Protection Proxy (with access)");
            Console.WriteLine("3. Protection Proxy (without access)");
            Console.WriteLine("4. Remote Proxy");
            Console.WriteLine("5. Smart Proxy");
            Console.WriteLine("6. Caching Proxy");
            Console.WriteLine("7. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    proxy = new VirtualProxy();
                    break;
                case "2":
                    proxy = new ProtectionProxy(true);
                    break;
                case "3":
                    proxy = new ProtectionProxy(false);
                    break;
                case "4":
                    proxy = new RemoteProxy();
                    break;
                case "5":
                    proxy = new SmartProxy();
                    break;
                case "6":
                    proxy = new CachingProxy();
                    break;
                case "7":
                    runProgram = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            if (proxy != null)
            {
                proxy.Request();
            }
        }
    }
}