using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    [SerializeField] private ParticleSystem deathEffect;
    [SerializeField] private ParticleSystem coin;
    [SerializeField] private TMP_Text collectedCoins;
    private Animator anim;
    private float time = 0.8f;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        CoinManager.Instance.CollectCoin();
        float a = float.Parse(collectedCoins.text);
        float coins = a + 1;
        collectedCoins.text = $"{coins}";
        anim.SetTrigger("Collect");
        deathEffect.Play();
        Destroy(gameObject, time);
        Destroy(coin, time);
        Destroy(deathEffect, time);
    }
}
