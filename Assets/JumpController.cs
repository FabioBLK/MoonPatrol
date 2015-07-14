using UnityEngine;
using System.Collections;

public class JumpController : MonoBehaviour {
	Rigidbody body;
	public float jumpForce;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		if (Input.GetButtonDown ("Jump")) {
			body.AddForce(new Vector3(body.velocity.x,jumpForce,body.velocity.z));
		}

		//Debug.Log (transform.position.y + " " + jumpForce);

	}
}
