using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="Cube(Clone)")
        {
            Time.timeScale=0.0f;
            Debug.Log("Hit");
            menu.SetActive(true);
        }
         Time.timeScale=1.0f;
    } 
}
