using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    [SerializeField] private GameObject DoorOn;
    [SerializeField] private GameObject DoorOff;

    private bool activ = false;


    void Update()
    {
        if (activ == true)
        {
            Enabling();
        }
    }


    private void OnTriggerEnter(Collider collider)
    {
        activ = true;
    }

        private void OnTriggerExit(Collider other)
    {
        activ = false;
    }

    private void Enabling()
    {
        DoorOff.SetActive(true);
        DoorOn.SetActive(false);
    }
}
