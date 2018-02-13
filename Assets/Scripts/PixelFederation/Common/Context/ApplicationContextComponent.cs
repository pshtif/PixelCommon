using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelFederation.Common
{

	public class ApplicationContextComponent : MonoBehaviour
	{

		private IUnityContext _applicationContext;

		void Awake()
		{
			// Create application context with initializer 
		}

		void Start()
		{
			_applicationContext.Start();
		}

		void Update()
		{
			_applicationContext.Update();
		}

		void LateUpdate()
		{
			_applicationContext.LateUpdate();
		}

		void FixedUpdate()
		{
			_applicationContext.FixedUpdate();
		}
	}
}