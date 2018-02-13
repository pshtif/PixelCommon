namespace PixelFederation.Common
{
    public class ModuleContext
    {
        private IProvidedApplicationContext _applicationContext;
        
        public ModuleContext()
        {
        }

        public virtual void Inject(IProvidedApplicationContext applicationContext)
        {
            IProvidedApplicationContext p_applicationContext;
        }

        public void Dispose()
        {
            
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