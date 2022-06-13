using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public float water = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger enter");

        if (other.gameObject.tag == "WaterDrop")
        {
            Destroy(other.gameObject);
            water += 5.0f * other.transform.localScale.x;

            if (water > 100.0f)
            {
                water = 100.0f;
            }
        }
    }

    void OnMouseDown()
    {
        GameObject waterCanButton = GameObject.Find("ButtonWaterCan");

        if (waterCanButton != null)
        {
            waterCanButton.transform.localPosition = transform.position + new Vector3(100.0f, 0.0f, 0.0f);
            GameManager.instance.plant = gameObject;
        }
    }
}
