using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().position = Vector3.zero;
		moveSpeed = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		float mhorizontal = Input.GetAxis("Horizontal");
		float mvertical = Input.GetAxis("Vertical");
		//transform.Translate (moveSpeed*mhorizontal*Time.deltaTime,0f,moveSpeed*mvertical*Time.deltaTime);
		Vector3 movement = new Vector3 (mhorizontal,0.0f,mvertical);
		rigidbody.velocity = movement * moveSpeed;
	}
}
