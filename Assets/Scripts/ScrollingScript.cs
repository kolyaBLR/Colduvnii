using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ScrollingScript : MonoBehaviour {

	public Vector2 speed = new Vector2(2, 2);

	public Vector2 direction = new Vector2(-1, 0);

	public bool isLinkedToCamera = false;

	public bool isLooping = false;

	private List<Transform> backgroundPart;

	void Start() {
		if (isLooping) {
			backgroundPart = new List<Transform>();
			for (int i = 0; i < transform.childCount; i++) {
				var child = transform.GetChild(i);
				if (child.GetComponent<Renderer>() != null) {
					backgroundPart.Add(child);
				}
			}
			backgroundPart = backgroundPart.OrderBy(t => t.position.x).ToList();
		}
	}

	void Update() {
		var movement = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);
		movement *= Time.deltaTime;
		transform.Translate(movement);

		if (isLinkedToCamera) {
			Camera.main.transform.Translate(movement);
		}
	}
}
