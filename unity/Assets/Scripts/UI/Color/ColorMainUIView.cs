using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ColorMainUIView : MonoBehaviour
{
	public Action OnNextClick = delegate { };
	public Action OnPreviousClick = delegate { };

	public Text m_Title;

	public void DisplayModel (ColorMainUIModel a_Model)
	{
		m_Title.text = a_Model.m_TitleName;
		m_Title.color = a_Model.m_TitleColor;
	}

	public void NextClick()
	{
		OnNextClick();
	}

	
	public void PreviousClick()
	{
		OnPreviousClick();
	}
}
