using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantsManager : MonoBehaviour
{
    [SerializeField] GameObject waterCan;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.editing)
        {
            waterCan.transform.position = new Vector3(1000f, 1000f, 0f);
        }
    }
}
