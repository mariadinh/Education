using System;

namespace Approach.Event_Delegate
{
    class Client
    {
        public void TestPubSub()
        {
            //create publisher of type integer
            var intPublisher = new Publisher<int>();


            //subscriber 1 subscribe to integer publisher
            var intSublisher1 = new Subscriber<int>(intPublisher);
            //event method to listen publish data
            intSublisher1.Publisher.DataPublisher += publisher_DataPublisher1;


            //subscriber 2 subscribe to interger publisher
            //event method to listen publish data
            var intSublisher2 = new Subscriber<int>(intPublisher);
            intSublisher2.Publisher.DataPublisher += publisher_DataPublisher2;

            intPublisher.PublishData(10); // publisher publish message
        }


        private static void publisher_DataPublisher2(object sender, MessageArgument<int> e)
        {
            Console.WriteLine("Subscriber 2 (+5): " + (e.Message + 5));
        }

        private static void publisher_DataPublisher1(object sender, MessageArgument<int> e)
        {
            Console.WriteLine("Subscriber 1 : " + e.Message);
        }
    }
}