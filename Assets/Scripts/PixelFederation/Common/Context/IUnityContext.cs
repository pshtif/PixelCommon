namespace PixelFederation.Common
{
    public interface IUnityContext
    {
        void Start();

        void Update();

        void LateUpdate();

        void FixedUpdate();
    }
}