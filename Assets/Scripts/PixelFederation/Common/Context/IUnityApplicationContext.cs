namespace Pixel
{
    public interface IUnityApplicationContext
    {
        void Start();

        void Update();

        void LateUpdate();

        void FixedUpdate();
    }
}