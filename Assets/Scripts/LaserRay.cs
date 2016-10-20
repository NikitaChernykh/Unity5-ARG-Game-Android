using UnityEngine;
using System.Collections;

public class LaserRay : MonoBehaviour {
	public GameObject rayOrigin;
	private LineRenderer laserLine;
	//private bool aimActive = true;
	void Start () {
		laserLine = GetComponent<LineRenderer> ();
	}

	void Update () {
		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		Ray cannonRay = new Ray (rayOrigin.transform.position,fwd);
		Debug.DrawLine (rayOrigin.transform.position,fwd,Color.green);
		laserLine.SetPosition (0, rayOrigin.transform.position);
		//if (aimActive) {
		if(Physics.Raycast (cannonRay, out hit, 50)){
			Debug.Log ("casting ray");
		}
			//if(hit.collider.tag == "environment"){
				//ActivateShooting();
			//}
		//}
	
	}
}
