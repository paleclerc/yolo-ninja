using UnityEngine;
using System.Collections;

public class TouchPlaySFX : MonoBehaviour {

	public string m_SFXName;

	void OnMouseDown () 
	{
		if(m_SFXName != string.Empty)
		{
			AudioManager.Instance.PlayAudioItem(m_SFXName);
		}
	}
}
