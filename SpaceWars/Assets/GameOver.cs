using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static float enemiesKilled = 0;

    void Update()
    {
        if (Player.isDead)
        {
            GameOver.FindObjectOfType<TextMeshProUGUI>().SetText("Game Over!\n\nEnemies Killed: " + enemiesKilled);
        }
    }
}
