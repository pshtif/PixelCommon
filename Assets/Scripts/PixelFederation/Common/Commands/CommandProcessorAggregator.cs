using System;
using System.Collections.Generic;

namespace PixelFederation.Common
{
    public class CommandProcessorAggregator
    {
        private List<ICommandProcessor> _commandProcessors;

        public CommandProcessorAggregator()
        {
            _commandProcessors = new List<ICommandProcessor>();
        }

        public void AddCommandProcessor(ICommandProcessor p_commandProcessor)
        {
            _commandProcessors.Add(p_commandProcessor);
        }

        public void Process(ICommandInputData inputData)
        {
            ICommandOutputData outputData;
            foreach (ICommandProcessor processor in _commandProcessors)
            {
                processor.Process(inputData, out outputData);
            }
        }
    }
}