using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager: MonoBehaviour {

	public Slider healthslider;

	void Start()
	{
		healthslider = GetComponent<Slider> ();
	}

	public void TakeDamage(float damage)
	{
		healthslider.value = healthslider.value - damage;
	}
}
