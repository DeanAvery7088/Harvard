using UnityEngine;
using System.Collections;

// The colon signifies that Coin is a class that extends (i.e. inherits from) class MonoBehavior 
public class Coin : MonoBehaviour {

	// Use this for initialization
	// The Start method is called whenever the component it's assigned to is instantiated
	void Start () {

	}

	// Update is called once per frame
	// Update is not called explicitely by the programmer; rather, it's built in!
	void Update () {

		// despawn coin if it goes past the left edge of the screen
		if (transform.position.x < -25) {
			Destroy(gameObject);
		}
		else {

			// ensure coin moves at the same rate as the skyscrapers do
			transform.Translate(-SkyscraperSpawner.speed * Time.deltaTime, 0, 0, Space.World);
		}

		// infinitely rotate this coin about the Y axis in world space
		transform.Rotate(0, 5f, 0, Space.World);
	}

	// 'other' represents what the Coin collider is colliding with
	void OnTriggerEnter(Collider other) {

		// trigger coin pickup function if a helicopter collides with this
		other.transform.parent.GetComponent<HeliController>().PickupCoin();
		Destroy(gameObject);	// destroy this coin
	}
}
