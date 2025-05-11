using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDeath : MonoBehaviour
{
    [SerializeField] private ParticleSystem deathEffect;


    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            deathEffect.Play();
        }
        Destroy(deathEffect, 0.6f);
    }
}
