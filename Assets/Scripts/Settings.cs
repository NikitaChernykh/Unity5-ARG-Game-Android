using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {
	public static bool rotateLeft;
	public static bool rotateRigth;
	public float speed =10;
	private float changingSpeed;

	void Start(){
		changingSpeed = speed;
	}
	void Update(){
		if (rotateLeft) {
			transform.Rotate (Vector3.up, changingSpeed * Time.deltaTime);
		}
		if (rotateRigth) {
			transform.Rotate (Vector3.down, changingSpeed * Time.deltaTime);
		}
	}

	public void RotateLeft(){
		rotateLeft = true;
		changingSpeed = speed;
	}
	public void RotateRigth(){
		rotateRigth = true;
		changingSpeed = speed;
	}
	public void RotateStop(){
		changingSpeed = 0;
		rotateLeft = false;
		rotateRigth = false;
	}
		
}
