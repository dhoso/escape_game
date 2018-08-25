using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	public Transform player;
	private Rigidbody rbody;
	private float speed = 30f;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 direction = Vector3.Normalize(player.position - this.transform.position);
		direction.y = 0f;
		rbody.AddForce(direction * speed);
	}
}
