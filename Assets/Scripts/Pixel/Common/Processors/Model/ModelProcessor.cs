using System;
using System.Collections.Generic;

namespace Pixel.Common.Processors
{
    public class ModelProcessor : IProcessor
    {
        private ModelManager _model;
        private Dictionary<Type, IModelCommand> _mapping;

        public ModelProcessor(ModelManager model)
        {
            _model = model;
            _mapping = new Dictionary<Type, IModelCommand>();
            
            _mapping.Add(typeof(SendTrainActionData), new SendTrainActionModelCommand());
        }
        
        public void Process(IActionData actionData)
        {
            Type type = actionData.GetType();
            if (_mapping.ContainsKey(type))
            {
                _mapping[type].Execute(_model, actionData);
            }
        }
    }
}