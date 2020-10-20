using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController2D controller;
	public Animator animator;
    // Start is called before the first frame update
	public float runSpeed = 40f;
	
	float horizontalMove = 0f;
    // Update is called once per frame
    void Update()
    {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
    }
	
	void FixedUpdate(){
		
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
	}
}
