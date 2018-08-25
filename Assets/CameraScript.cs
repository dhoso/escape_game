using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public Transform target;
	public Vector3 relativePosition;

	void Start () {
		GetComponent<Transform>().position = target.position + relativePosition;
	}

	void Update () {
		GetComponent<Transform>().position = target.position + relativePosition;
	}
}
