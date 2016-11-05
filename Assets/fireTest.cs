using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fireTest : MonoBehaviour {
	//Drag in the Bullet Emitter from the Component Inspector.
	public GameObject bulletEmitter;
	//Drag in the Bullet Prefab from the Component Inspector.
	public GameObject bullet;
	//Enter the Speed of the Bullet from the Component Inspector.
	public float bulletForwardForce;
	public float fireRate = 1f;
	public GameObject shootButton;

	private AudioSource cannonSound;
	private float nextFire;




	void Start(){
		cannonSound = GetComponent<AudioSource> ();
	}

	public void Shoot () {
		
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			//The Bullet instantiation happens here.
			GameObject temporaryBulletHandler;
			temporaryBulletHandler = Instantiate (bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation) as GameObject;

			//Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
			//This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
			temporaryBulletHandler.transform.Rotate (Vector3.left * 90);

			//Retrieve the Rigidbody component from the instantiated Bullet and control it.
			Rigidbody temporaryRigidBody;
			temporaryRigidBody = temporaryBulletHandler.GetComponent<Rigidbody> ();

			//Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
			temporaryRigidBody.AddForce (transform.forward * bulletForwardForce);

			StartCoroutine (ShotEffect ());

			//Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
			Destroy (temporaryBulletHandler, 10.0f);
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
