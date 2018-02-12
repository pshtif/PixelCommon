using Application.Networking;
using PixelFederation.Libraries.Networking;

namespace PixelFederation.Common
{
    public class NetworkProcessor : ICommandProcessor
    {
        private INetworking _networking;

        public NetworkProcessor(INetworking networking)
        {
            _networking = networking;
        }

        public void Process(ICommandInputData p_inputData, ICommandOutputData p_outputData)
        {
            ICommandData data = actionData as ICommandData;
            if (data != null) 
            {
                CommandData commandData = new CommandData();
                commandData.SetData(data);
                _networking.SendCommand(commandData);
            }
        }
    }
}