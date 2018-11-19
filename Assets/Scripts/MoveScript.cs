using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	public Vector2 speed;

	public Vector2 direction = new Vector2(-1, 0);

	public Vector2 movement;

	private Rigidbody2D rb2D;

	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		movement = new Vector2(direction.x * speed.x, direction.y * speed.y);
		rb2D.velocity = movement;
	}
}
