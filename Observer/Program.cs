using Observer;
using System;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;

        // Basic Observer Setup
        BasicSubject basicSubject = new BasicSubject();
        BasicObserver basicObserver1 = new BasicObserver("Observer 1");
        BasicObserver basicObserver2 = new BasicObserver("Observer 2");
        basicSubject.Attach(basicObserver1);
        basicSubject.Attach(basicObserver2);

        // Push Observer Setup
        PushSubject pushSubject = new PushSubject();
        PushObserver pushObserver1 = new PushObserver("Push Observer 1");
        pushSubject.Attach(pushObserver1);

        // Pull Observer Setup
        PullSubject pullSubject = new PullSubject();
        PullObserver pullObserver1 = new PullObserver(pullSubject);
        pullSubject.Attach(pullObserver1);

        // Event Driven Observer Setup
        EventDrivenSubject eventSubject = new EventDrivenSubject();
        EventObserver eventObserver1 = new EventObserver("Event Observer 1", eventSubject);

        // Weak Reference Observer Setup
        WeakReferenceSubject weakSubject = new WeakReferenceSubject();
        WeakObserver weakObserver1 = new WeakObserver("Weak Observer 1");
        weakSubject.Attach(weakObserver1);

        while (runProgram)
        {
            Console.WriteLine("Choose an Observer Pattern Implementation:");
            Console.WriteLine("1. Basic Observer (Notify all)");
            Console.WriteLine("2. Push Observer (Push data)");
            Console.WriteLine("3. Pull Observer (Pull data)");
            Console.WriteLine("4. Event Driven Observer (Trigger event)");
            Console.WriteLine("5. Weak Reference Observer (Notify with weak reference)");
            Console.WriteLine("6. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    basicSubject.ChangeState("New State");
                    break;
                case "2":
                    pushSubject.SetState("Push Data");
                    break;
                case "3":
                    pullSubject.SetState("Pull Data");
                    break;
                case "4":
                    eventSubject.SetState("Event State");
                    break;
                case "5":
                    weakSubject.Notify("Weak State");
                    break;
                case "6":
                    runProgram = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
        }
    }
}
