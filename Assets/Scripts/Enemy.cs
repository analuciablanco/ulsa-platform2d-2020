﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.GameplaySystem;

public class Enemy : MonoBehaviour, IFlip
{
    [SerializeField] float moveSpeed = 3f;

    [SerializeField] float delay = 2f;

    float timer;

    [SerializeField] Vector2 dir;

    private void Update() 
    {
        transform.Translate(dir * moveSpeed * Time.deltaTime);

        timer += Time.deltaTime;

        if(timer >= delay)
        {
            timer = 0;
            dir = dir == Vector2.right ? Vector2.left : Vector2.right;
        }
    }

    public void FlipSprite()
    {
        throw new System.NotImplementedException();
    }
}
