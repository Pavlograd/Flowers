using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlant : MonoBehaviour
{
    public GameObject plant;

    public void SpawnPlant()
    {
        GameObject newObejct = Instantiate(plant, new Vector3(0.0f, 0.0f, -0.1f), Quaternion.identity);
        newObejct.name = newObejct.name.Replace("(Clone)", "");
        Destroy(gameObject);
    }
}
