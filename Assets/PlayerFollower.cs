using UnityEngine;
using System.Collections;

public class PlayerFollower : MonoBehaviour {
	
	public float speed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.position = transform.position + new Vector3(0,0,speed);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.position = transform.position + new Vector3(0,0,-speed);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.position = transform.position + new Vector3(speed,0,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position = transform.position + new Vector3(-speed,0,0);
		}
		
	
		Camera.main.transform.position = transform.position + new Vector3(0,20,0);
		
	}
}
