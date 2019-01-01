using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public Vector2 newSpan;

	private WeaponScript weapon;
	private HealthScript health;

	void Awake() {
		weapon = GetComponent<WeaponScript>();
		health = GetComponent<HealthScript>();
	}
	
	void Update () {
		if (weapon != null && weapon.CanAttack) {
			weapon.AttactLeft(true);
		}
	}

	private void OnBecameInvisible() {
		Vector2 position = transform.position;
		transform.position = new Vector2(position.x + newSpan.x, position.y + newSpan.y);
		health.Restart();
	}
}