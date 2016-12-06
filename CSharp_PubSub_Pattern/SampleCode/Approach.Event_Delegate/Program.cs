using System;

namespace Approach.Event_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
           var client = new Client();
            client.TestPubSub();
            Console.ReadKey();
        }
    }
}
