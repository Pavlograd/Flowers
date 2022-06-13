using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger enter");

        if (other.gameObject.tag == "WaterDrop")
        {
            Destroy(other.gameObject);
        }
    }
}
