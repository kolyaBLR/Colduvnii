using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchScript : MonoBehaviour {

    public Vector2 speed;
	private Rigidbody2D rb2D;

	private void Start()
    {
		rb2D = GetComponent<Rigidbody2D>();
    }

	private void OnCollisionEnter2D(Collision2D collision) {
		bool damagePlayer = false;
		EnemyScript enemy = collision.gameObject.GetComponent<EnemyScript>();
		if (enemy != null) {
			HealthScript enemyHealth = enemy.GetComponent<HealthScript>();
			if (enemyHealth != null) {
				enemyHealth.Damage(enemyHealth.hp);
			}
			damagePlayer = true;
		}
		if (damagePlayer) {
			HealthScript playerHealth = GetComponent<HealthScript>();
			if (playerHealth != null) {
				playerHealth.Damage(1);
			}
		}
	}

	void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
		HandleMovement(new Vector2(horizontal, vertical));

        bool shot = Input.GetButtonDown("Fire1");
        shot |= Input.GetButtonDown("Fire2");
        if (shot) {
            WeaponScript weapon = GetComponent<WeaponScript>();
            if (weapon != null) {
                weapon.AttackRight(false);
            }
        }
	}

    private void HandleMovement(Vector2 position)
    {
        rb2D.velocity = new Vector2(position.x * speed.x, position.y * speed.y);
    }
}
