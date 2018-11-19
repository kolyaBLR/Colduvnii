using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour {

	public Transform shotPrefab;

	public float shootingRate = 0.25f;

	private float shootCooldown;

	void Start () {
		shootCooldown = 0f;
	}
	
	void Update () {
		if (shootCooldown > 0) {
			shootCooldown -= Time.deltaTime;
		}
	}

	public void AttactLeft(bool isEnemy) {
		Attact(isEnemy, this.transform.right * -1);
	}

	public void AttackRight(bool isEnemy) {
		Attact(isEnemy, this.transform.right);
	}

	public void Attact(bool isEnemy, Vector2 direction) {
		if (CanAttack) {
			shootCooldown = shootingRate;
			var shotTransform = Instantiate(shotPrefab);
			shotTransform.position = transform.position;
			ShotScrpit shot = shotTransform.gameObject.GetComponent<ShotScrpit>();
			if (shot != null) {
				shot.isEnimyShot = isEnemy;
			}
			MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
			if (move != null) {
				move.direction = direction;
			}
		}
	}

	public bool CanAttack {
		get {
			return shootCooldown <= 0f;
		}
	}
}
