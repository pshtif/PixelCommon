namespace PixelFederation.Common
{
    public interface IModelCommand
    {
        void Execute(ModelManager model, IActionData actionData);
    }
}