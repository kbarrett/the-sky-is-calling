using UnityEngine;
using System.Collections;

public class PlayerFollower : MonoBehaviour {
	
	public float maxSpeed;
    public Vector3 speed = Vector3.zero;
    float acc = 0.1f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        bool inputAccepted = false;
		if(Input.GetKey(KeyCode.UpArrow))
		{
            if (speed.z < maxSpeed)
            {
                speed.z += acc;
            }
            inputAccepted = true;
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
            if (speed.z > -maxSpeed)
            {
                speed.z -= acc;
            }
            inputAccepted = true;
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
            if (speed.x < maxSpeed)
            {
                speed.x += acc;
            }
            inputAccepted = true;
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
            if (speed.x > -maxSpeed)
            {
                speed.x -= acc;
            }
            inputAccepted = true;
		}

        if (!inputAccepted)
        {
            if (speed.x < 0)
            {
                speed.x += 2 * acc;
            }
            else if (speed.x > 0)
            {
                speed.x -= 2*acc;
            }
            if (speed.y < 0)
            {
                speed.y += 2 * acc;
            }
            else if (speed.y > 0)
            {
                speed.y -= 2 * acc;
            }
            if (speed.z < 0)
            {
                speed.z += 2 * acc;
            }
            else if (speed.z > 0)
            {
                speed.z -= 2 * acc;
            }
        }

        transform.Translate(speed);
	
		Camera.main.transform.position = transform.position + new Vector3(0,20,0);
		
	}
}
