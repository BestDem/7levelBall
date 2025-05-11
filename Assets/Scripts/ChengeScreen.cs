using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChengeScreen : MonoBehaviour
{
    [SerializeField] private GameObject BackP;
    [SerializeField] private GameObject MenuPanel;
    public void OnButtonChangeScene(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void SceneRest()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        CoinManager.Instance.ResetStars();
        Debug.Log("рестрарт");
    }
    
    public void LoadLevel(int levelIndex)
    {
        CoinManager.Instance.SetCurrentLevel(levelIndex);
    }

    public void SceneRestLevelOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        CoinManager.Instance.ResetStars();
        BackP.SetActive(false);
        MenuPanel.SetActive(false);
    }
}
