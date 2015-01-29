using UnityEngine;
using System.Collections;
using System;

public class ColorMainUIController : MonoBehaviour 
{
	public Action OnNextEvent = delegate { };
	public Action OnPreviousEvent = delegate { };
	
	public ColorMainUIView m_View;

	private void Start()
	{
		m_View.OnNextClick += OnNextClick;
		m_View.OnPreviousClick += OnPreviousClick;
	}

	public void DisplayUI(string a_TitleName, Color a_TitleColor)
	{
		ColorMainUIModel model = new ColorMainUIModel();
		model.m_TitleName = a_TitleName;
		model.m_TitleColor = a_TitleColor;

		DisplayModel(model);
	}

	void DisplayModel (ColorMainUIModel a_Model)
	{
		m_View.DisplayModel(a_Model);
	}
	
	void OnNextClick ()
	{
		Debug.Log("NEXT");
		OnNextEvent();
	}

	void OnPreviousClick ()
	{
		Debug.Log("Previous");
		OnPreviousEvent();
	}
}
