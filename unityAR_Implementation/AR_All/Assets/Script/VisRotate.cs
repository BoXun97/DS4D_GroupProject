using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisRotate : MonoBehaviour
{

    

   
    float xSpeed = 150f;

   
    void Start()
    {

    }

   
    void Update()
    {

        
        if (Input.GetMouseButton(0))
        {
            
            if (Input.touchCount == 1)
            {
                
                if (Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    
                    transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime);
                }
            }
        }
    }
}