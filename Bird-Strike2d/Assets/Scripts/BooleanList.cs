using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BooleanListObject")]
public class BooleanList : ScriptableObject
{
    [SerializeField][TextArea] private bool[] booleans;
    
    public bool[] Boolean => booleans;
}
