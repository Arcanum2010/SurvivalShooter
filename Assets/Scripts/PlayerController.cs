using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 6f;

	Vector3 movement;
	Animator anim;
	Rigidbody playerRb;
	int floorMask;

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
		

	}
}
