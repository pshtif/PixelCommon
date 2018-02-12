using System.Collections;
using System.Collections.Generic;
using Pixel;
using UnityEngine;

public class ApplicationContextComponent : MonoBehaviour
{

	private IUnityApplicationContext _applicationContext;

	void Awake()
	{
		_applicationContext = new ApplicationContext();
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
