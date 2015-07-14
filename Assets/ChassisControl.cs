using UnityEngine;
using System.Collections;

public class ChassisControl : MonoBehaviour {

	public GameObject referencia;
	Vector3 refPosition,myPosition,myRotation;
	float distanciaX,distanciaY,distanciaZ,myRotationZ;
	public float timer,rotacao;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (refPosition.y + " - " + myRotationZ);

		PosicaoChassis ();

		if(refPosition.y>0.3f && rotacao<=15){
			rotacao ++;
			myRotationZ = Mathf.Clamp (rotacao,0,15);
			myRotation = new Vector3(transform.rotation.x,transform.rotation.y,myRotationZ);
		}

		if(refPosition.y<0.3f && rotacao>0){
			//Debug.Log("EXECUTANTO " + rotacao + "Posicao da Roda: "+refPosition.y);
			rotacao --;
			myRotationZ = Mathf.Clamp (rotacao,0,15);
			myRotation = new Vector3(transform.rotation.x,transform.rotation.y,myRotationZ);
		}

	}

	void FixedUpdate(){
		refPosition = referencia.transform.position;
		distanciaX = refPosition.x - 1.5f;
		distanciaY = Mathf.Lerp (transform.position.y, refPosition.y + 0.5f, timer);
		distanciaZ = refPosition.z + 2;
	}

	void PosicaoChassis ()
	{
		myPosition = new Vector3 (distanciaX, distanciaY, distanciaZ);
		transform.position = myPosition;
		transform.localEulerAngles = myRotation;
	}
}
