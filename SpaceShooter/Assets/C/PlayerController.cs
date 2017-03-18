using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	float mhorizontal = Input.GetAxis("Horizontal");
	float mvertical = Input.GetAxis("Vertical");

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().position = Vector3.zero;
		moveSpeed = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (moveSpeed*mhorizontal*Time.deltaTime,0f,moveSpeed*mvertical*Time.deltaTime);
		//rigidbody.position = new Vector3 (
			//Mathf.Clamp (rigidbody.postion.x, xMin, xMax)
				//, 0.0f
				//, Mathf.Clamp (rigidbody.postion.z, zMin, zMax)
		//);
	}
}
