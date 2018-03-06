using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firing: MonoBehaviour {


	public float power = 100f;

	public Slider slider;
	public GameObject shellPrefab;
	GameObject shell;
	public GameObject spawnPos;
	public GameObject barrel;


	public void Fire() {

		if (Input.GetButton("Fire1")) {
			Debug.Log (Input.mousePosition.x);
			shell = Instantiate (shellPrefab, spawnPos.transform.position, Quaternion.identity) as GameObject;
			//		shell.GetComponent<Rigidbody>().AddForce((spawnPos.transform.position - barrel.transform.position) * slider.value * power);

			shell.GetComponent<Rigidbody> ().velocity = (spawnPos.transform.position - barrel.transform.position).normalized * slider.value * power;
		}
	}

}
