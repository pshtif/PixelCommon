using System.Collections.Generic;
using System.Reflection;

namespace PixelFederation.Common
{
    public class ApplicationContext : IProvidedApplicationContext
    {
        private List<ModuleContext> _contexts;

        public ApplicationContext()
        {
            _contexts = new List<ModuleContext>();
        }

        public void AddContext(ModuleContext p_context)
        {
            _contexts.Add(p_context);
        }
    }
}