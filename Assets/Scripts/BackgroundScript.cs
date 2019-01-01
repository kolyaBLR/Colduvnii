using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {

	public int xSpan = 40;

	private void OnBecameInvisible() {
		transform.position = new Vector2(transform.position.x + xSpan, transform.position.y);
	}
}
