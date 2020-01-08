using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
	public float RotationSpeed = 100f;
	
	// Update is called once per frame
	void Update ()
	{
		Rotate();
	}
	
	void Rotate()
	{
		transform.Rotate(0f, 0f, RotationSpeed * Time.deltaTime);
	}
}
