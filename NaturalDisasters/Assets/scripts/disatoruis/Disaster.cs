using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Disaster" , menuName = "New Disaster")]
public class Disaster : ScriptableObject
{
    //[SerializeField]
     //string name;

    [Header("Population")]
    [Range(0  , 1)]
    public float killPercentage;
    [Header("Development")]
    [Range(0 , 1)]
    public float DamagAmount;
}
