using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Image[] level1Stars;
    public Image[] level2Stars;
    public Image[] level3Stars;
    public Image[] level4Stars;
    public Image[] level5Stars;
    public Image[] level6Stars;
    public Image[] level7Stars;


    public Sprite starFilled; //заполненная звезда
    public Sprite starEmpty;

    private void Start()
    {
        UpdateStarsForLevel(1, level1Stars); //обновление звезд
        UpdateStarsForLevel(2, level2Stars);
        UpdateStarsForLevel(3, level3Stars);
        UpdateStarsForLevel(4, level4Stars);
        UpdateStarsForLevel(5, level5Stars);
        UpdateStarsForLevel(6, level6Stars);
        UpdateStarsForLevel(7, level7Stars);
    }

    private void UpdateStarsForLevel(int levelIndex, Image[] stars)
    {
        int coinsCollected = CoinManager.Instance.LoadCoinsForLevel(levelIndex);

        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].sprite = (coinsCollected > i) ? starFilled : starEmpty;
        }
    }
}