using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixRotator : MonoBehaviour
{
    public float rotationSpeed = 350f;
    public float rotationSpeedAndroid = 50f;

    private void Update()
    {

        // #if UNITY_EDITOR
        //     // This input is only for the pc it will not work for mobile
        //     if(Input.GetMouseButton(0))
        //     {
        //         float mouseX = Input.GetAxisRaw("Mouse X");
        //         transform.Rotate (transform.position.x, -mouseX * rotationSpeed * Time.deltaTime, transform.position.z);
        //     }

        // #elif UNITY_ANDROID
            // This is for the mobile
            if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                float xDeltaPos = Input.GetTouch(0).deltaPosition.x;
                transform.Rotate (transform.position.x, -xDeltaPos * rotationSpeedAndroid * Time.deltaTime, transform.position.z);
            }

        //#endif
    }
}
