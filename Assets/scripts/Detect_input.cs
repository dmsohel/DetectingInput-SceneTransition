using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_input : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Called Awake Function");  
    }
   private void Start()
    {
        Debug.Log("Called start Function\n");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("F button detected once");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("left mouse button clicked once");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("left mouse button clicked continuosly");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F button is pressed continuosly");
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("F button is released");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("left mouse button is released");
        }
    }
}
