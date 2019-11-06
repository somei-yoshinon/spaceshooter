using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject text;
    public enemybox box;


    public void GameOver()
    {
        text.SetActive(true);
        box.Stop();
        enemy[] enemies = FindObjectsOfType<enemy>();
        foreach (var ene in enemies)
        {
            ene.enabled = false;
        }
    }
}
