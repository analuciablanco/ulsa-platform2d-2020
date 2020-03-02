﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.GameplaySystem;

public class Character2D : MonoBehaviour
{

    //si se pone protected se puede ver en todo lo que lo herede
    protected SpriteRenderer spr;
    protected Animator anim;

    protected Rigidbody2D rb2D;

    [SerializeField,Range(1f,10f)] protected float jumpForce = 7f;

    [SerializeField] protected float moveSpeed = 7f;

    //Raycast
    [SerializeField]
    Color rayColor = Color.magenta;
    [SerializeField,Range(0.1f, 5f)]
    float rayDistance = 5f;
    [SerializeField]
    LayerMask groundLayer;


    void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    /*
   protected bool FlipSprite
    {
        //Operacion ternaria
        // condicion ? si es verdad : si es falso
        get => GameplaySystem.Axis.x < 0f ? true : GameplaySystem.Axis.x > 0 ? false : spr.flipX;
    }
    */

    protected bool Grounding
    {
        get => Physics2D.Raycast(transform.position, Vector2.down, rayDistance, groundLayer);
    }
    
    //Con este se pinta el ray Color 
    void OnDrawGizmosSelected()
    {

        Gizmos.color = rayColor;
        Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);

    }

   
 
}

