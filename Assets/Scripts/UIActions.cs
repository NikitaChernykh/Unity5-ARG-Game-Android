using UnityEngine;
using System.Collections;

public class UIActions : MonoBehaviour {

	public GameObject Cannon;

	//Drag in the Bullet Prefab from the Component Inspector.
	public GameObject CannonBall;

	//Enter the Speed of the Bullet from the Component Inspector.
	public float CannonBall_Forward_Force;

	public void Shoot () {
		
		//The Bullet instantiation happens here.
		//GameObject Temporary_CannonBall_Handler;
		//Temporary_CannonBall_Handler = Instantiate(CannonBall,Cannon.transform.position,Cannon.transform.rotation) as GameObject;
		Instantiate(CannonBall,Cannon.transform.position,Cannon.transform.rotation);
		//Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
		//This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
		//Temporary_CannonBall_Handler.transform.Rotate(Vector3.left * 90);



		//Retrieve the Rigidbody component from the instantiated Bullet and control it.
		//Rigidbody Temporary_RigidBody;
		//Temporary_RigidBody = Temporary_CannonBall_Handler.GetComponent<Rigidbody>();
		//Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
		//Temporary_RigidBody.AddForce(transform.forward * CannonBall_Forward_Force);

		//Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
		//Destroy(Temporary_CannonBall_Handler, 3.0f);

	}
}
