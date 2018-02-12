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

        public void Process(ICommandInputData p_inputData)
        {
            ICommandOutputData outputData;
            foreach (ICommandProcessor processor in _commandProcessors)
            {
                processor.Process(p_inputData, out outputData);
            }
        }
    }
}