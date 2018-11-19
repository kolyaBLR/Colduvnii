using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

	public int hp = 3;

	public bool isEnemy = true;

	void Start () {
		
	}
	
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		ShotScrpit shot = other.gameObject.GetComponent<ShotScrpit>();
		if (shot !=  null) {
			if (shot.isEnimyShot != isEnemy) {
				Damage(shot.danage);
				Destroy(shot.gameObject);
			}
		}
	}

	public void Damage(int damageCount) {
		hp -= damageCount;
		if (hp <= 0) {
			Destroy(gameObject);
		}
	}
}
