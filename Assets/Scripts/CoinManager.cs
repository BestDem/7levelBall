using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;
    public GameObject[] stars;
    
    private int currentLevelCoins = 0;
    private int totalCoinsCount;
    private int currentLevelIndex = 0;

    public int CurrentLevelCoins => currentLevelCoins;

    private void Awake()
    {
        Instance = this;
    }

    public void SetCurrentLevel(int levelIndex)
    {
        currentLevelIndex = levelIndex;
        currentLevelCoins = 0;
        ResetStars();
    }

    public void CollectCoin()
    {
        currentLevelCoins++;
    }

    public void StarsOn()
    {
        int starsToShow = CalculateStars(currentLevelCoins);
        for (int i = 0; i < starsToShow; i++)
        {
            if (i < stars.Length)
            {
                stars[i].SetActive(true);
            }
        }
    }
    
    private int CalculateStars(int coins)
    {
        if (coins == 3) return 3;
        if (coins == 2) return 2;
        if (coins == 1) return 1;
        return 0;
    }

    public void ResetStars()
    {
        foreach(GameObject star in stars)
        {
            star.SetActive(false);
        }
    }

    public void SaveCoinsForCurrentLevel()
    {
        string key = "Level" + currentLevelIndex + "_Coins";
        PlayerPrefs.SetInt(key, currentLevelCoins);
        PlayerPrefs.Save();
    }

    public int LoadCoinsForLevel(int levelIndex)
    {
        string key = "Level" + levelIndex + "_Coins";
        return PlayerPrefs.GetInt(key, 0);
    }
}
