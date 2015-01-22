using UnityEngine;
using System.Collections;

public class RandomMove : MonoBehaviour
{
	public float m_RandomMinValue = -0.1f;
	public float m_RandomMaxValue = 0.1f;

	public float m_MinMagnitude = 0.005f;
	public float m_SlowDownByFrame = 0.05f;

	public float m_TooFarX = 5;
	public float m_TooFarY = 5;

	private Vector2 m_Speed;

	// Use this for initialization
	void Start () 
	{
		m_Speed = CreateRandomMove(m_RandomMinValue, m_RandomMaxValue);
	}
	
	// Update is called once per frame
	void Update () 
	{
		m_Speed = m_Speed * (1-m_SlowDownByFrame);

		transform.Translate(m_Speed);

		if(m_Speed.magnitude < m_MinMagnitude)
		{
			m_Speed = CreateRandomMove(m_RandomMinValue, m_RandomMaxValue);
		}

		if(transform.position.x > m_TooFarX || transform.position.x < -m_TooFarX)
		{
			transform.position = new Vector2(0,transform.position.y);
		}

		if(transform.position.y > m_TooFarY || transform.position.y < -m_TooFarY)
		{
			transform.position = new Vector2(transform.position.x,0);
		}
	}

	Vector2 CreateRandomMove(float a_MinValue, float a_MaxValue)
	{
		float x = Random.Range(a_MinValue, a_MaxValue);
		float y = Random.Range(a_MinValue, a_MaxValue);
		Vector2 newValue = new Vector2(x,y);
		return newValue;
	}
}
