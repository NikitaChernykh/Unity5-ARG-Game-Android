using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_movement : MonoBehaviour {

	public float speed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}
}
