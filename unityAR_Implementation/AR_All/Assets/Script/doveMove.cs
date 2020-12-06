using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class doveMove : MonoBehaviour
{
    public GameObject DovePrefab;
    private float touchTime;
    private bool newTouch = false;
    private Animator dove;
    float xSpeed = 150f;

    // Start is called before the first frame update
    void Start()
    {
        dove = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dove.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            dove.SetBool("takeoff", false);
            dove.SetBool("landing", false);
            dove.SetBool("fly", false);
            dove.SetBool("falling", false);
        }

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray,out hitInfo))
            {

                if (Input.touchCount == 1)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Moved)
                    { 
                        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime);
                    }




                    Touch touch = Input.GetTouch(0);

                    if(touch.phase == TouchPhase.Began)
                    {
                        newTouch = true;
                        touchTime = Time.time;
                    }else if (touch.phase == TouchPhase.Stationary)
                    {
                        if (newTouch == true && Time.time - touchTime > 2f)
                        {
                            newTouch = false;
                            dove.SetBool("takeoff", true);
                            dove.SetBool("idle", false);
                            dove.SetBool("falling", false);
                        }
                    }
                      
                }
              
            }
        }
    }
}
