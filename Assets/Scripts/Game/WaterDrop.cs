using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDrop : MonoBehaviour
{
    float speed = 1.2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += -Vector3.up * speed * Time.deltaTime;

        if (transform.localScale.x < 2.0f)
        {
            transform.localScale += Vector3.one * (speed / 2.0f) * Time.deltaTime;
        }
    }
}
