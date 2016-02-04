using UnityEngine;
using System.Collections;

public class MonkeyBall : MonoBehaviour {

	public Rigidbody body;
	public float minTilt = 5f;
	public float sensitivity = 1f;

	public Transform monkeyPivot;
	public float monkeyLookSpeed = 10f;

	Vector3 totalRotation = Vector3.zero;

	void Awake()
	{
		if (SystemInfo.supportsGyroscope)
			Input.gyro.enabled = true;
		else
			Application.Quit();
	}

	// Update is called once per frame
	void Update () 
	{
		Vector3 rotation = Input.gyro.rotationRate * Mathf.Rad2Deg;

		if (Mathf.Abs (rotation.x) < minTilt)
			rotation.x = 0;
		if (Mathf.Abs (rotation.y) < minTilt)
			rotation.y = 0;
		if (Mathf.Abs (rotation.z) < minTilt)
			rotation.z = 0;

		totalRotation += new Vector3 (-rotation.x, rotation.z, -rotation.y) * Time.deltaTime;
	}

	void FixedUpdate()
	{
		body.AddTorque (totalRotation * sensitivity);
	}

	void LateUpdate()
	{
		if (monkeyPivot != null) 
		{
			// Which direction is the ball moving
			Vector3 velocity = body.velocity;
			// Don't want monkey looking up and down, only left and right
			velocity.y = 0f;

			// Determine direction the monkey is facing
			Vector3 fwd = monkeyPivot.forward;
			fwd.y = 0f;

			// Frame-rate independent
			float step = monkeyLookSpeed * Time.deltaTime;

			// Rotate the monkey in the new direction
			Vector3 newFacing = Vector3.RotateTowards (fwd, velocity, step, 0f);

			monkeyPivot.rotation = Quaternion.LookRotation (newFacing);
		}
	}
}