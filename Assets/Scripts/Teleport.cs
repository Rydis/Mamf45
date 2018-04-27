using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public Transform destination;

	void start ()  {
		destination = GetComponent<Transform> ();
	}

	void update() {
	}
		
	private void onTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			var startPosition = other.transform.position;
			other.transform.position = destination.position;
			var moveDelta = other.transform.position - startPosition;
			Camera.main.transform.position += moveDelta;
		}
	}
}