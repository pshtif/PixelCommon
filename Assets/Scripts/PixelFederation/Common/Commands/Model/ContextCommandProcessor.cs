using System;
using System.Collections.Generic;

namespace PixelFederation.Common
{
    public class ContextCommandProcessor<T> : ICommandProcessor where T : ModuleContext
    {
        private T _context;
        private Dictionary<Type, IContextCommand<T>> _mapping;

        public ContextCommandProcessor(T model)
        {
            _context = model;
            _mapping = new Dictionary<Type, IContextCommand<T>>();
        }
        
        public void Process(ICommandInputData inputData, out ICommandOutputData outputData)
        {
            Type type = inputData.GetType();
            if (_mapping.ContainsKey(type))
            {
                _mapping[type].Execute(_context, inputData, out outputData);
            }
        }
    }
}