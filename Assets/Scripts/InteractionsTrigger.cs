using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class InteractionsTrigger : MonoBehaviour
{
    [SerializeField] private GameObject canvasTrigger;
    [SerializeField] private GameObject objecton;

    private bool activ = false;

    private void Start()

    {
        canvasTrigger.SetActive(false);
    }

    void Update()
    {
        if (activ == true && Input.GetKeyDown(KeyCode.E))
        {
            if(CompareTag("TurnOn"))
            {
                Enabling();
                Destroy(gameObject);
            }
        }
    }


    private void OnTriggerEnter(Collider collider)
    {
        canvasTrigger.SetActive(true);
        activ = true;
    }

        private void OnTriggerExit(Collider other)
    {
        canvasTrigger.SetActive(false);
        activ = false;
    }

    private void Enabling()
    {
        objecton.SetActive(!objecton.activeSelf);
        canvasTrigger.SetActive(false);
    }
}
