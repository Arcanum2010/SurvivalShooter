using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 6f;

	Vector3 movement;
	Animator anim;
	Rigidbody playerRb;
	int floorMask;
	float camRayLength = 100f;

	// Use this for initialization
	void Awake () {
		playerRb = GetComponent<Rigidbody>();


	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
	}

	void Update () {

	}

	void Rotation () {
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit floorHit;
		
		if(Physics.Raycast (camRay, out floorHit, camRayLength, floorMask))
        {
            // Create a vector from the player to the point on the floor the raycast from the mouse hit.
            Vector3 playerToMouse = floorHit.point - transform.position;

            // Ensure the vector is entirely along the floor plane.
            playerToMouse.y = 0f;

            // Create a quaternion (rotation) based on looking down the vector from the player to the mouse.
            Quaternion newRotation = Quaternion.LookRotation (playerToMouse);

            // Set the player's rotation to this new rotation.
            playerRigidbody.MoveRotation (newRotation);
        }
		
	}
}
