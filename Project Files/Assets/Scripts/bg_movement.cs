using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_movement : MonoBehaviour
{

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = -Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = transform.position.z; 
            touchPosition.y = transform.position.y;
            transform.position = touchPosition;

        }
    }
}
