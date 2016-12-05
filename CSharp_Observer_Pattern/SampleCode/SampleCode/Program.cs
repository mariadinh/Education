using System;

namespace SampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject state and notify observers
            Console.WriteLine("Change subject state to ABC");
            s.SubjectState = "ABC";
            Console.WriteLine("Notify observers");
            s.Notify();

            // Wait for user
            Console.ReadKey();
        }
    }
}
