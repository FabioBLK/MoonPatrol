using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour {

	GameObject rodaFD,rodaFE,rodaTD,rodaTE;
	//Rigidbody rbRodaFD,rbRodaFE,rbRodaTD,rbRodaTE;
	Rigidbody rbCar;
	public float mySpeed;
	float currentSpeed,speed;
	float rodaFDPosY;

	// Use this for initialization
	void Start () {
	
		currentSpeed = mySpeed;

		rodaFD = transform.FindChild ("RodaFD").gameObject;
		rodaFE = transform.FindChild ("RodaFE").gameObject;
		rodaTD = transform.FindChild ("RodaTD").gameObject;
		rodaTE = transform.FindChild ("RodaTE").gameObject;

		/*
		rbRodaFD = rodaFD.GetComponent<Rigidbody>();
		rbRodaFE = rodaFE.GetComponent<Rigidbody>();
		rbRodaTE = rodaTD.GetComponent<Rigidbody>();
		rbRodaTD = rodaTE.GetComponent<Rigidbody>();
		*/

		rbCar = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

		print(currentSpeed);
		rbCar.AddForce (new Vector3(currentSpeed,0,0));


	}

	void OnCollisionEnter(Collision col){
		currentSpeed=mySpeed;
	}

	void OnCollisionExit(Collision col){
		//currentSpeed = 1;
	}

}
