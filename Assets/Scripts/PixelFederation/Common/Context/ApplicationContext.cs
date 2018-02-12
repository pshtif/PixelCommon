namespace Pixel
{
    public class ApplicationContext : IProvidedApplicationContext, IUnityApplicationContext
    {
        public ApplicationContext()
        {
            // Set up provider
            ApplicationContextProvider.Init(this);
        }

        public void Start()
        {
            
        }
        
        public void Update()
        {
            
        }
        
        public void LateUpdate()
        {
            
        }
        
        public void FixedUpdate()
        {
            
        }
    }
}