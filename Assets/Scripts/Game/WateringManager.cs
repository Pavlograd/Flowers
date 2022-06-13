using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringManager : MonoBehaviour
{
    [SerializeField] PlantsData data;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject item in data.plants)
        {
            if (item.name == CrossScenesInfos.plantName)
            {
                Instantiate(item, new Vector3(0.0f, -1.6f, 0.0f), Quaternion.identity);
            }
        }
    }
}
