namespace PixelFederation.Common
{
    public interface ICommandProcessor
    {
        void Process(ICommandInputData p_inputData, out ICommandOutputData p_outputData);
    }
}