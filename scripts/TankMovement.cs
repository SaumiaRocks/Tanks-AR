using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TankMovement : MonoBehaviour {

	GameObject barrel;
	public float speed = 20f;
	public float turnSpeed = 180f;

	void Awake(){
		
		barrel = GameObject.FindGameObjectWithTag ("Barrel");
		transform.Rotate (0f, 0f, 180f);
	}

	#region TankMovement
	public void front(){
		GetComponent<Rigidbody> ().MovePosition (transform.position + transform.forward * speed * Time.deltaTime);
	}
	public void back(){
		GetComponent<Rigidbody> ().MovePosition (transform.position + (-transform.forward) * speed * Time.deltaTime);
	}
	public void left(){
		GetComponent<Rigidbody> ().MoveRotation (GetComponent<Rigidbody> ().rotation * Quaternion.Euler (0f, turnSpeed * Time.deltaTime, 0f));
	}
	public void right(){
		GetComponent<Rigidbody> ().MoveRotation (GetComponent<Rigidbody> ().rotation * Quaternion.Euler (0f, -turnSpeed * Time.deltaTime, 0f));
	}
	#endregion 


	#region barrelMovement
	public void rotateup(){
		
		if (barrel.transform.rotation.z >= -0.65f && barrel.transform.rotation.z <= 0f) {
			barrel.transform.Rotate (new Vector3 (0f, 0f, turnSpeed * Time.deltaTime));
			Debug.Log ("barrel rotation z = " + barrel.transform.rotation.z);
		}

		if (barrel.transform.rotation.z < -0.65f) {
			Debug.Log ("barrel rotation z = " + barrel.transform.rotation.z);
			barrel.transform.rotation = Quaternion.Euler (0f, 0f, -90f);
		}


		if (barrel.transform.rotation.z > 0f) {
			barrel.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
		}

	}
	public void rotatedown(){
		if (barrel.transform.rotation.z >= -0.65f && barrel.transform.rotation.z <= 0f) {
			Debug.Log ("barrel rotation z = " + barrel.transform.rotation.z);
			barrel.transform.Rotate (new Vector3 (0f, 0f, -turnSpeed * Time.deltaTime));
		}

		if (barrel.transform.rotation.z < -0.65f) {
			Debug.Log ("barrel rotation z = " + barrel.transform.rotation.z);
			barrel.transform.rotation = Quaternion.Euler (0f, 0f, -90f);
		}


		if (barrel.transform.rotation.z > 0f) {
			barrel.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
		}

	}
	#endregion
}
