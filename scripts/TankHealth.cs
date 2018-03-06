using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour {
	
	public float damage = 10f;
	public UiManager ui;

	//	void Awake()
	//	{
	//		ui1 = GetComponent<uiscript> ();
	//	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag== "bullet") {
			ui.TakeDamage(damage);
		}
	}
}