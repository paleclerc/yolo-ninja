using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ColorGameMain : MonoBehaviour 
{
	public ColorMainUIController m_UI;
	public List<ColorGameInfo> m_ListColor;
	public FormGameInfo m_FormInfo;
	public SpriteRenderer m_Form;

	private int m_CurrentColor;
	private const string m_FormatTitle = "{0} {1}";

	// Use this for initialization
	void Start () 
	{
		m_CurrentColor = 0;
		m_UI.OnNextEvent += OnNextEvent;
		m_UI.OnPreviousEvent += OnPreviousEvent;
		ChangeColor(m_CurrentColor);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnNextEvent ()
	{
		ChangeColor(m_CurrentColor+1);
	}

	void OnPreviousEvent ()
	{
		ChangeColor(m_CurrentColor-1);
	}

	void ChangeColor (int a_ColorIndex)
	{
		m_CurrentColor = a_ColorIndex;

		if(m_CurrentColor >= m_ListColor.Count)
		{
			m_CurrentColor = 0;
		}
		if(m_CurrentColor < 0)
		{
			m_CurrentColor = m_ListColor.Count-1;
		}

		if(m_ListColor.Count == 0)
		{
			return;
		}

		string colorName = m_ListColor[m_CurrentColor].m_NameMasculin;
		if(!m_FormInfo.m_Masculin)
		{
			colorName = m_ListColor[m_CurrentColor].m_NameFeminin;
		}
		string title = string.Format(m_FormatTitle,m_FormInfo.m_Name,colorName);
		m_UI.DisplayUI(title, m_ListColor[m_CurrentColor].m_Color);
		m_Form.color = m_ListColor[m_CurrentColor].m_Color;
	}
}

[Serializable]
public class ColorGameInfo
{
	public Color m_Color = Color.white;
	public string m_NameMasculin;
	public string m_NameFeminin;
}

[Serializable]
public class FormGameInfo
{
	public string m_Name;
	public bool m_Masculin = true;
}