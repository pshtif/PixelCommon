using System.Collections.Generic;
using NUnit.Framework;

namespace PixelFederation.Common
{
    public class ActionProcessor
    {
        private List<IProcessor> _processors;

        public ActionProcessor()
        {
            _processors = new List<IProcessor>();
        }

        public void AddProcessor(IProcessor processor)
        {
            _processors.Add(processor);
        }

        public void Process(IActionData actionData)
        {
            foreach (IProcessor processor in _processors)
            {
                processor.Process(actionData);
            }
        }
    }
}