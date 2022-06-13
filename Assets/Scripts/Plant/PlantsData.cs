using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlantsData", menuName = "ScriptableObjects/PlantsData", order = 1)]
public class PlantsData : ScriptableObject
{
    public GameObject[] plants;
}