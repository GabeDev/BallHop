using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChangeMain()
    {
        SceneManager.LoadScene("MainGame");
        //
    }
    public void SceneChangeHome()
    {
        SceneManager.LoadScene("StartScreen");

    }
     public void SceneChangeTutorial()
    {
        SceneManager.LoadScene("Tutorial");

    }
    public void quit()
    {
         Application.Quit();
    }
}
