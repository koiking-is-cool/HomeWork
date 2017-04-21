using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject spaceShip;
	public float tilt;

	// Use this for initialization
	void Start () {
		//spaceship not tilt
		GetComponent<Rigidbody> ().rotation = Quaternion.identity;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)
			&&spaceShip.gameObject.transform.position.x>=-11.5f)
		{
			spaceShip.gameObject.transform.position = new Vector3
			(
			spaceShip.gameObject.transform.position.x-1
			,spaceShip.gameObject.transform.position.y
			,spaceShip.gameObject.transform.position.z
			);
		}
		else if(Input.GetKey(KeyCode.RightArrow)
			&&spaceShip.gameObject.transform.position.x<=11.5f){
			spaceShip.gameObject.transform.position = new Vector3
				(
					spaceShip.gameObject.transform.position.x+1
					,spaceShip.gameObject.transform.position.y
					,spaceShip.gameObject.transform.position.z
				);
		}else if(Input.GetKey(KeyCode.UpArrow)
			&&spaceShip.gameObject.transform.position.z<=7.4f){
			spaceShip.gameObject.transform.position = new Vector3
				(
					 spaceShip.gameObject.transform.position.x
					,spaceShip.gameObject.transform.position.y
					,spaceShip.gameObject.transform.position.z+1
				);
		}else if(Input.GetKey(KeyCode.DownArrow)
			&&spaceShip.gameObject.transform.position.z>=-3.4f){
			spaceShip.gameObject.transform.position = new Vector3
				(
					 spaceShip.gameObject.transform.position.x
					,spaceShip.gameObject.transform.position.y
					,spaceShip.gameObject.transform.position.z-1
				);
		}
	}
}
