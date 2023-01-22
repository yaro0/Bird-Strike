using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameStats")]
public class GameStats : ScriptableObject
{
    [SerializeField] public bool turbAnnouced;
    [SerializeField] public bool turbulenceOngoing;
    [SerializeField] public bool callAnswered;
    [SerializeField] public bool callOngoing;
    [SerializeField] public bool rightButtonPressed;
    [SerializeField] public int healthLeft;


}
