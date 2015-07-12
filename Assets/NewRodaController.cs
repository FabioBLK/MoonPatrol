using UnityEngine;
using System.Collections;

public class NewRodaController : MonoBehaviour {
	
	public float maxDistance;
	float myDistance;
	float terrainHigh;
	Ray ray;
	RaycastHit hit;
	Vector3 myPos,myParentPosition,vectorDirecao;
	Terrain terreno;

	// Use this for initialization
	void Start () {
		terreno = FindObjectOfType<Terrain>();
	}
	
	// Update is called once per frame
	void Update () {
		myParentPosition = GetComponentInParent<Transform>().position;

		myPos = transform.position;

		vectorDirecao = new Vector3(0,-10,0);

		terrainHigh = terreno.SampleHeight (transform.position) - 100.5f;

		ray = new Ray (transform.position,vectorDirecao);

		Debug.DrawRay(ray.origin,ray.direction*maxDistance);
		print (myPos.y + " - " + maxDistance + " Terrain " + terrainHigh);

		if(Physics.Raycast(ray,out hit,maxDistance)){
				myDistance = Mathf.Lerp(myPos.y,hit.distance,0.5f)+2.0f*Time.deltaTime;
				transform.position=new Vector3(myPos.x,myDistance,myPos.z);
		}else{
			myDistance = Mathf.Clamp(myParentPosition.y,myParentPosition.y-0.001f,myParentPosition.y-0.1f);
			transform.position = new Vector3(myParentPosition.x,myDistance,myParentPosition.z);
		}

	}
}
