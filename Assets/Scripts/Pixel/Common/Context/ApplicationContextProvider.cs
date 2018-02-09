using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelFederation.Common
{
    public static class ApplicationContextProvider
    {

        private static IProvidedApplicationContext _applicationContext;

        public static void Init(IProvidedApplicationContext p_applicationContext)
        {
            _applicationContext = p_applicationContext;
        }

        // Decoration to access through IProvidedApplicationContext
    }
}