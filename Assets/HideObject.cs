using UnityEngine;
using System.Collections;

public class HideObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Time.timeSinceLevelLoad > 20 && !renderer.isVisible)
		{
			Destroy(gameObject);
		}
	}
}
