using UnityEngine;
using System.Collections;

public class Teste : MonoBehaviour {

	public GameObject referencia;
	Vector3 myPosition,refPosition;
	float distancia;
	Quaternion refRotation,myRotation;

	// Use this for initialization
	void Start () {

	}

	void Update(){
		refPosition = referencia.transform.position;
		distancia = refPosition.x-3;

		refRotation = referencia.transform.rotation;

		myPosition = new Vector3 (distancia,transform.position.y,transform.position.z);



		transform.position = myPosition;
		transform.rotation = refRotation;

		print ("roda2 " + transform.position.z);
	}

}
