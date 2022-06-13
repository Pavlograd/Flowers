using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIWater : MonoBehaviour
{
    Plant plant;
    [SerializeField] Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("FindPlant", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (plant != null)
        {
            slider.value = plant.water;
        }
    }

    void FindPlant()
    {
        plant = GameObject.FindGameObjectsWithTag("Plant")[0].GetComponent<Plant>();

    }
}
