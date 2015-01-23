using UnityEngine;
using System.Collections;

public class AutoResize : MonoBehaviour 
{
	public float m_MaxSizePercent = 2;
	public float m_Speed = 0.1f;

	private float m_CurrentSpeed;
	// Use this for initialization
	void Start ()
	{
		m_CurrentSpeed = m_Speed;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(transform.localScale.x > m_MaxSizePercent)
		{
			transform.localScale = new Vector2(m_MaxSizePercent,m_MaxSizePercent);
			m_CurrentSpeed = -m_Speed;
		}
		else if (transform.localScale.x < 1)
		{
			transform.localScale = Vector2.one;
			m_CurrentSpeed = m_Speed;
		}

		float x = transform.localScale.x*m_CurrentSpeed;
		float y = transform.localScale.y*m_CurrentSpeed;

		transform.localScale = new Vector2(transform.localScale.x+x,transform.localScale.y+y);

	}
}
