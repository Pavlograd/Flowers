using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    [SerializeField] GameObject waterDropPreFab;
    [SerializeField] Transform waterDropPosition;
    float timerWaterDrop;
    bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        timerWaterDrop += Time.deltaTime;

        if (timerWaterDrop >= 0.5f && clicked)
        {
            Debug.Log("Spawn waterDrop");
            timerWaterDrop = 0.0f;
            SpawnWaterDrop();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (clicked)
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            worldPosition.z = 0.0f;
            transform.position = worldPosition;
        }
    }

    void OnMouseDown()
    {
        Debug.Log("MouseClicked");
        clicked = true;
    }

    void OnMouseUp()
    {
        Debug.Log("MouseUp");
        clicked = false;
    }

    void SpawnWaterDrop()
    {
        Instantiate(waterDropPreFab, waterDropPosition.position, Quaternion.identity);
    }
}
