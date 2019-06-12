using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    
    float score=0;
    bool stop = false;
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(scoreCounter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator scoreCounter()
    {
        while(!stop)
        {
       
        yield return new WaitForSeconds(5);
        score+=50;
        scoretext.text=""+score;
        }
    }
}
