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
