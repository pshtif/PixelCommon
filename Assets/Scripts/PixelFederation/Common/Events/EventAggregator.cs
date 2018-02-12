using System;
using System.Collections.Generic;

namespace PixelFederation.Common
{

    public interface IEvent
    {
    }

    public delegate void EventHandler<T>(T evt) where T : IEvent;


    public interface IHandlers
    {
        void Trigger(object evt);
    }

    public class Handlers<T> : IHandlers where T : IEvent
    {
        public List<EventHandler<T>> Items;

        public Handlers()
        {
            Items = new List<EventHandler<T>>();
        }

        public void Trigger(object evt)
        {
            for (var i = Items.Count - 1; i >= 0; i--)
            {
                EventHandler<T> handler = Items[i];
                handler.Invoke((T) evt);
            }
        }
    }

    public class EventAggregator
    {
        private IDictionary<Type, IHandlers> handlers;
        private IDictionary<Type, IEvent> eventInstancePool;

        private int NumberOfHandlers;

        public EventAggregator()
        {
            handlers = new Dictionary<Type, IHandlers>();
            eventInstancePool = new Dictionary<Type, IEvent>();
            NumberOfHandlers = 0;
        }

        public void Register<T>(EventHandler<T> handler) where T : IEvent
        {
            if (!handlers.ContainsKey(typeof(T)))
            {
                handlers[typeof(T)] = new Handlers<T>();
            }

            Handlers<T> handlersStackNew = handlers[typeof(T)] as Handlers<T>;


            handlersStackNew.Items.Add(handler);

            NumberOfHandlers++;
        }

        public void Unregister<T>(EventHandler<T> handler) where T : IEvent
        {
            if (handlers.ContainsKey(typeof(T)))
            {
                Handlers<T> handlerStack = handlers[typeof(T)] as Handlers<T>;

                if (handlerStack.Items.Contains(handler))
                {
                    handlerStack.Items.Remove(handler);

                    NumberOfHandlers--;
                }
            }
        }

        //TODO - add possibility to trigger just with the type, for events without parameters, to not create instance of the event

        private IEvent GetEventInstance(Type eventType)
        {
            IEvent eventInstance;
            if (!eventInstancePool.TryGetValue(eventType, out eventInstance))
            {
                eventInstance = Activator.CreateInstance(eventType) as IEvent;
                if (eventInstance != null)
                {
                    eventInstancePool.Add(eventType, eventInstance);
                }
            }

            return eventInstance;
        }

        public void Trigger(Type eventType)
        {
            Trigger<IEvent>(GetEventInstance(eventType));
        }

        public void Trigger<T>(T evt) where T : IEvent
        {
            if (handlers.ContainsKey(evt.GetType()))
            {
                IHandlers handlerStack = handlers[evt.GetType()];
                handlerStack.Trigger(evt);
            }
        }

        public int GetNumberOfHandlers()
        {
            return NumberOfHandlers;
        }
    }
}