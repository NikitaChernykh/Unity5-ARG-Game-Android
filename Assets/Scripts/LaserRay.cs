using UnityEngine;
using System.Collections;

public class LaserRay : MonoBehaviour {
	public Transform cannonEnd;
	public float weaponRange = 5;
	public GameObject camera;
	private LineRenderer laserLine;
	//private LineRenderer laserLine;
	//private bool aimActive = true;
	void Start () {
		laserLine = GetComponent<LineRenderer> ();
	}

	void Update () {
		Vector3 rayOrigin = camera.GetComponent<Camera>().ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
		RaycastHit hit;
		laserLine.SetPosition (0, cannonEnd.position);
		if (Physics.Raycast (rayOrigin, camera.transform.forward, out hit, weaponRange)) {
			Debug.Log ("yyyy");
			laserLine.SetPosition (1, hit.point);
		} else {
			laserLine.SetPosition (1, rayOrigin + (camera.transform.forward * weaponRange));
		
		}
	
	}
}
