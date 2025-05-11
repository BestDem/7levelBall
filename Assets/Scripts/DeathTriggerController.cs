using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTriggerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        CoinManager.Instance.ResetStars();
    }
}
