namespace PixelFederation.Common
{
    public interface IContextCommand<in T> where T : ModuleContext
    {
        void Execute(T context, ICommandInputData inputData, out ICommandOutputData outputData);
    }
}