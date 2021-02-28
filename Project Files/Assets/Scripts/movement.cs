using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                Vector3 touchPosition = speed*Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = transform.position.z;
                touchPosition.y = transform.position.y;
                transform.position = touchPosition;

            }
    }
}
