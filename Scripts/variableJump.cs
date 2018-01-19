using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variableJump : MonoBehaviour {

    public float fallMultiplifier = 2.5f;
    public float lowJumpMultiplifier = 2f;

    private Rigidbody2D rb;
    private Animator anim;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(rb.velocity.y < 0)
        {
            anim.SetBool("IsJumping", false);
            anim.SetBool("IsFalling", true);
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplifier - 1) * Time.deltaTime;
        }
        else if(rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplifier - 1) * Time.deltaTime;
        }
	}
}
