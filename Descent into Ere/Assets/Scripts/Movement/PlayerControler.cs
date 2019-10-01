using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
	//Jump Vars
	public Rigidbody2D rb;
	public float moveSpeed;
	public float jumpPower;
	float targetMoveSpeed;
	//is Grounded
	public bool isGrounded;
	public LayerMask groundLayers;

	void Update () {
		//isGrounded?
		Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f), 
			new Vector2(transform.position.x + 0.5f, transform.position.y +0.51f), groundLayers);
		//Movement
		targetMoveSpeed = Mathf.Lerp(rb.velocity.x, Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, Time.deltaTime * 10);
		rb.velocity = new Vector2 (targetMoveSpeed, rb.velocity.y);

		//Jump Stuff
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (Vector2.up * jumpPower, ForceMode2D.Impulse);
		}
	}
}
