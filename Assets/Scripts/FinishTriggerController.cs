using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class FinishTriggerController : MonoBehaviour
{
    [SerializeField] private int levelIndex;
    [SerializeField] private GameObject canvasTriggerResult;
    [SerializeField] private GameObject pause;
    [SerializeField] private Rigidbody Ball;

    private void OnTriggerEnter(Collider collider)
    {
        CoinManager.Instance.StarsOn();
        pause.SetActive(false);
        canvasTriggerResult.SetActive(true);
        Ball.isKinematic = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
    private void FinishAnim(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 6)
        {
            Animator animator = GetComponent<Animator>();
            animator.SetBool("Finish",true);
        }
    }
    
}
