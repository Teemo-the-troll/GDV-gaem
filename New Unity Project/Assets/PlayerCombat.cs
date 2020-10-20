﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
	public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
		{
			Attack();
		}
    }
	
	void Attack()
	{
		//Play attack
		animator.SetTrigger("Attack");
		//Detect enemies
		//Damage
	}
}
