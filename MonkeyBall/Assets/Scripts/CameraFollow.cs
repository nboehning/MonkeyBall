using UnityEngine;
using System.Collections;

// Author: Nathan Boehning
// Purpose: Make the camera follow the ball
public class CameraFollow : MonoBehaviour 
{
	public Transform ball;


	void LateUpdate()
	{
		transform.position = ball.position;
	}
}
