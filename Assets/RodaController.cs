using UnityEngine;
using System.Collections;

public class RodaController : MonoBehaviour {

	public float speed=2;
	public float myVelocity;
	public float jumpForce;
	Vector3 rodaPos;
	Rigidbody body;
	float direcao,currentSpeed;
	
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		
		//transform.Translate (new Vector3 (speed, 0, 0));
		body.AddForce(new Vector3(currentSpeed,0,0));
	}
	
	void Update(){
		direcao = Input.GetAxisRaw ("Horizontal");
		//print ("roda1 " + transform.position.z);

		//if (Input.GetButtonDown ("Jump")) {
		//	body.AddForce(new Vector3(body.velocity.x,jumpForce,body.velocity.z));
		//}


		SetSpeed ();


		
		
		
	}
	
	void SetSpeed ()
	{
		if (direcao == 1) {
			currentSpeed = speed + myVelocity;
		}
		if (direcao == -1) {
			currentSpeed = speed - myVelocity;
		}
		if (direcao == 0) {
			currentSpeed = speed;
		}
	}
}
