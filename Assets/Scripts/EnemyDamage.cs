﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

    public int attackDmg;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy" && GameObject.Find("Player").GetComponent<PlayerController>().isAttacking)
        {
            other.gameObject.GetComponent<AI>().MinusHP(attackDmg);
        }
    }
}
