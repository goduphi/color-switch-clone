using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
	public Transform ball;
	// Update is called once per frame
	void Update ()
	{
		//if the ball has moved passed the current position of the camera
		//we change the position of the camera to be the y position of the ball
		if(ball.position.y > transform.position.y)
		{
			transform.position = new Vector3(transform.position.x, ball.position.y, transform.position.z);
		}
	}
}
