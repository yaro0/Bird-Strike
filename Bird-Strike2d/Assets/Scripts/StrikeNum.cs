using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StrikeNum : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private GameStats gameStats;

    void Update()
    {
        int numOfStikes = 3 - gameStats.healthLeft;
        text.text = numOfStikes.ToString(); 
    }
}
