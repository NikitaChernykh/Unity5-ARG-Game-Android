using UnityEngine;
using System.Collections;

public class ViewRay : MonoBehaviour {
	public float weaponRange = 5;
	public GameObject ARcam;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 lineOrigin = ARcam.GetComponent<Camera>().ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
		Debug.DrawRay (lineOrigin, ARcam.transform.forward * weaponRange, Color.green);
	}
}
