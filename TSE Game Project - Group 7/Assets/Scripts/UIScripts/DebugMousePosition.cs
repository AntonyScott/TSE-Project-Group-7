using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMousePosition : MonoBehaviour
{
    Vector3 mouse;

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        Debug.Log(mouse.x);
        Debug.Log(mouse.y);
        Debug.Log(mouse.z);
    }
}
