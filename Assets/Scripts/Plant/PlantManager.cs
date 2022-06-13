using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantManager : MonoBehaviour
{
    [SerializeField] Plant plant;
    [SerializeField] PlantEditor plantEditor;
    [SerializeField] SpriteRenderer spriteRenderer;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.editing)
        {
            plant.enabled = false;
            plantEditor.enabled = true;
        }
        else
        {
            plant.enabled = true;
            plantEditor.enabled = false;
        }
    }
}
