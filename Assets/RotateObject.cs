using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject itemToRotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateItemObject();
    }

    public void RotateItemObject()
    {
        if(Input.touchCount == 1)
        {
            float rotateSpeed = 0.09f;
            Touch touchZero = Input.GetTouch(0);
 
            //Rotate the model based on offset
            Vector3 localAngle = itemToRotate.transform.localEulerAngles;
            localAngle.y -= rotateSpeed * touchZero.deltaPosition.x;
            itemToRotate.transform.localEulerAngles = localAngle;
        }
    }
}
