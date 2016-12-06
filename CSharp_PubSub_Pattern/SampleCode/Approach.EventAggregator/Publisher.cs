namespace Approach.EventAggregator
{
    public class Publisher
    {
        EventAggregator EventAggregator;
        public Publisher(EventAggregator eventAggregator)
        {
            EventAggregator = eventAggregator;
        }

        public void PublishMessage()
        {
            EventAggregator.Publish(new Mymessage());
            EventAggregator.Publish(10);
        }
    }
}