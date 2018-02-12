using System;

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

        public static void Register<T>(EventHandler<T> handler) where T : IEvent
        {
            _eventAggregator.Register(handler);
        }

        public static void Unregister<T>(EventHandler<T> handler) where T : IEvent
        {
            _eventAggregator.Unregister(handler);
        }

        public static void Trigger(Type eventType)
        {
            _eventAggregator.Trigger(eventType);
        }

        public static void Trigger<T>(T evt) where T : IEvent
        {
            _eventAggregator.Trigger(evt);
        }
    }
}