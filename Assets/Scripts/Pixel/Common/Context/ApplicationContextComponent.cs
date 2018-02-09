using System.Collections;
using System.Collections.Generic;
using PixelFederation.Common;
using UnityEngine;

public class ApplicationContextComponent : MonoBehaviour
{

	private ApplicationContext _applicationContext;
	
	void Awake () {
		_applicationContext = new ApplicationContext();
	}
}
