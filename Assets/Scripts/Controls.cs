using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float minSwipeDistY;
 
    public float minSwipeDistX;
    public Rigidbody rb;
         
    private Vector2 startPos;
 
    public float thrust;
    void Update()
    {
//#if UNITY_ANDROID
        if (Input.touchCount > 0) 
             
        {
             
            Touch touch = Input.touches[0];
             
             
             
            switch (touch.phase) 
                 
            {
                 
            case TouchPhase.Began:
 
                startPos = touch.position;
                 
                break;
                 
                 
                 
            case TouchPhase.Ended:
 
                   
                     
                    float swipeDistHorizontal = (new Vector3(touch.position.x,0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
                     
                    if (swipeDistHorizontal > minSwipeDistX) 
                         
                    {
                         
                        float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
                         
                        if (swipeValue > 0)
                        {
                             rb.AddForce(thrust, 0,0, ForceMode.Impulse);
                        }
                             
                            
                         
                        else if (swipeValue < 0)
                        {
                            rb.AddForce(-thrust, 0,0, ForceMode.Impulse);
                        }
                             
                            //MoveLeft ();
                         
                    }
                break;
            }
        }
    }
}
