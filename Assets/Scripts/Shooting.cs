using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {

	public GameObject bullet;
	public GameObject cam;
	public GameObject shootButton;
	public float fireRate = 1f;
	private float nextFire;

	private AudioSource cannonSound;

	// Use this for initialization
	void Start () {
		cannonSound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	public void Shoot () {
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;

			Destroy (Instantiate (bullet, cam.transform.position, cam.transform.rotation), 5f);
			StartCoroutine (ShotEffect ());
		}
	}

	private IEnumerator ShotEffect()
	{
		cannonSound.Play ();
		shootButton.GetComponent<Button> ().interactable = false;
		yield return new WaitForSeconds(fireRate); 
		shootButton.GetComponent<Button> ().interactable = true;
	}

}
