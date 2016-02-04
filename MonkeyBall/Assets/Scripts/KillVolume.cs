﻿using UnityEngine;
using System.Collections;

public class KillVolume : MonoBehaviour {

	public Transform respawnPoint;

	void OnTriggerEnter(Collider other)
	{
		other.transform.position = respawnPoint.position;
		other.attachedRigidbody.velocity = Vector3.zero;
	}
}
