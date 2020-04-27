using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour
{
    public GameObject targetObject;
    private float targetAngle = 0;
    const float rotationAmount = 1.5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            targetAngle -= 90.0f;
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            targetAngle += 90.0f;
        }
      
        if(targetAngle !=0)
        {
            Rotate();
        }
    }
    
    protected void Rotate()
    {
        if (targetAngle>0)
        {
            transform.RotateAround(targetObject.transform.position, Vector3.up, -rotationAmount);
            targetAngle -= rotationAmount;
        }
        else if(targetAngle <0)
        {
            transform.RotateAround(targetObject.transform.position, Vector3.up, rotationAmount);
            targetAngle += rotationAmount;
        }
    }
}