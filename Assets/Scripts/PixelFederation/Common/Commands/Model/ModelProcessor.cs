using System;
using System.Collections.Generic;

namespace PixelFederation.Common
{
    public class ModelProcessor : ICommandProcessor
    {
        private ModelManager _model;
        private Dictionary<Type, IModelCommand> _mapping;

        public ModelProcessor(ModelManager model)
        {
            _model = model;
            _mapping = new Dictionary<Type, IModelCommand>();
            
            _mapping.Add(typeof(SendTrainActionData), new SendTrainActionModelCommand());
        }
        
        public ICommandOutputData Process(IActionData actionData)
        {
            Type type = actionData.GetType();
            if (_mapping.ContainsKey(type))
            {
                _mapping[type].Execute(_model, actionData);
            }
        }
    }
}