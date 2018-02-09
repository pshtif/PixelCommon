namespace PixelFederation.Common
{
    public static class EventAggregatorProvider
    {

        private static EventAggregator _eventAggregator;

        public static void Init(EventAggregator p_eventAggregator)
        {
            _eventAggregator = p_eventAggregator;
        }

        // Decoration to access
    }
}