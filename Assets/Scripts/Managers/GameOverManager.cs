﻿using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;


    Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (PlayerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
        }
    }
}
