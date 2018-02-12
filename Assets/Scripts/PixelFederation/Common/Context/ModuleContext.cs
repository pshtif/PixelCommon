namespace Pixel
{
    public class ModuleContext
    {
        private IProvidedApplicationContext _applicationContext;
        
        public ModuleContext(IProvidedApplicationContext p_applicationContext)
        {
            _applicationContext = p_applicationContext;
        }
    }
}