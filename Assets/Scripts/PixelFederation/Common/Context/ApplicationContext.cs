using System;
using System.Collections.Generic;

namespace PixelFederation.Common
{
    public class ApplicationContext : IProvidedApplicationContext, IUnityContext
    {
        private List<ModuleContext> _moduleContexts;
        private CommandProcessorAggregator _commandProcessorAggregator;
        
        public ApplicationContext(IApplicationContextInitializer initializer)
        {
            // Initialize lists
            _moduleContexts = new List<ModuleContext>();
            _commandProcessorAggregator = new CommandProcessorAggregator();
            
            // Set up provider
            ApplicationContextProvider.Init(this);

            initializer.Initialize(this);
        }

        public void AddContext<T>() where T : ModuleContext, new()
        {
            ModuleContext moduleContext = new T();
            moduleContext.Inject(this);
            _moduleContexts.Add(moduleContext);
        }

        public void DisposeContext(ModuleContext moduleContext)
        {
            moduleContext.Dispose();
            _moduleContexts.Remove(moduleContext);
        }

        public void Start()
        {
            foreach (ModuleContext context in _moduleContexts)
            {
                if (context is IUnityContext)
                {
                    context.Start();
                }
            }
        }
        
        public void Update()
        {
            foreach (ModuleContext context in _moduleContexts)
            {
                if (context is IUnityContext)
                {
                    context.Update();
                }
            }
        }
        
        public void LateUpdate()
        {
            
            foreach (ModuleContext context in _moduleContexts)
            {
                if (context is IUnityContext)
                {
                    context.LateUpdate();
                }
            }
        }
        
        public void FixedUpdate()
        {
            foreach (ModuleContext context in _moduleContexts)
            {
                if (context is IUnityContext)
                {
                    context.FixedUpdate();
                }
            }
        }
    }
}