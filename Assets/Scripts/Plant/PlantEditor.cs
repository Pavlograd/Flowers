using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEditor : MonoBehaviour
{
    public bool clicked = false;
    [SerializeField] PlantManager plantManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnDisable()
    {
        clicked = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger enter");
    }

    void FixedUpdate()
    {
        if (clicked)
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            worldPosition.z = -0.1f;
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
}
