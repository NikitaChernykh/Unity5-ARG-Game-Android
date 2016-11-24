using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed = 3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}
}
