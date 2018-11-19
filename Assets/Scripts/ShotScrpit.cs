using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScrpit : MonoBehaviour {

	public int danage = 1;

	public bool isEnimyShot = false;

	void Start () {
		Destroy(gameObject, 20);
	}
	
	void Update () {
		
	}
}
