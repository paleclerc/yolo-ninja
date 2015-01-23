using UnityEngine;
using System.Collections;

public class TouchSpin : MonoBehaviour {

	public float m_SpinSpeed = 2;
	public float m_SlowDownSpeed = 0.1f;
	private float m_CurrentSpinSpeed;
	// Use this for initialization
	void Start () 
	{
		m_CurrentSpinSpeed = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(m_CurrentSpinSpeed > 0)
		{
			Vector3 rotation = new Vector3(0,0,m_CurrentSpinSpeed);
			transform.Rotate(rotation);

			m_CurrentSpinSpeed -= m_SlowDownSpeed;
			if(m_CurrentSpinSpeed < 0)
			{
				m_CurrentSpinSpeed = 0;
			}
		}
	}

	void OnMouseDown () 
	{
		m_CurrentSpinSpeed = m_SpinSpeed;
	}
}
