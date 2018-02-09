using Application.Networking;
using PixelFederation.Libraries.Networking;

namespace PixelFederation.Common.Processors
{
    public class NetworkProcessor : IProcessor
    {
        private INetworking _networking;

        public NetworkProcessor(INetworking networking)
        {
            _networking = networking;
        }

        public void Process(IActionData actionData)
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