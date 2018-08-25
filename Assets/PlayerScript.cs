using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public Rigidbody rbody;
	private float speed = 30f;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		float x = Input.GetAxis("Horizontal") * speed;
		float z = Input.GetAxis("Vertical") * speed;
		rbody.AddForce(x, 0, z);
	}
}
