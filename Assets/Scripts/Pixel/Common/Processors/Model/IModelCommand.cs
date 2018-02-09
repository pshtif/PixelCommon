namespace Pixel.Common.Processors
{
    public interface IModelCommand
    {
        void Execute(ModelManager model, IActionData actionData);
    }
}