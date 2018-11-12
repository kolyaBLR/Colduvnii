using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchController : MonoBehaviour {

    public float horizontalSpeed;
    public float verticalSpeed;
	private Rigidbody2D rb2D;

	private void Start()
    {
		rb2D = GetComponent<Rigidbody2D>();
    }

	void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
		HandleMovement(horizontal, vertical);
	}

    private void HandleMovement(float horizontal, float vertical)
    {
        rb2D.velocity = new Vector2(horizontal * horizontalSpeed, vertical * verticalSpeed);
    }
}
