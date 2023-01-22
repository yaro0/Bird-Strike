using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameStats")]
public class GameStats : ScriptableObject
{
    [SerializeField] public bool turbAnnouced;
    [SerializeField] public bool callAnswered;
    [SerializeField] public int healthLeft;

}
