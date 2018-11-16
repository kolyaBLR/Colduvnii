using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	public Vector2 speed;

	private Rigidbody2D rb2D;

	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		rb2D.velocity = new Vector2((rb2D.velocity.x - 1) * speed.x, (rb2D.velocity.y - 1) * speed.y);
	}
}
