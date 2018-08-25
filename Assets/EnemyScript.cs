using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	public Transform player;
	private Rigidbody rbody;
	private float speed = 3f;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 diff = player.position - this.transform.position;
		rbody.AddForce(diff * speed);
	}
}
