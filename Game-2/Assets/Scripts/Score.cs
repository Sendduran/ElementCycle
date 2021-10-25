using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update

    public Text score; //ref for UI text object to display score
    public float scoreAmount; // variable to hold the score amount 
    public float persec; // multiplier 

    void Start()
    {
        scoreAmount = 0f;
        persec = 3f;   
    }

    // Update is called once per frame
    void Update()
    {
     
        score.text = (int)scoreAmount + "" ;  //initializing the score 
        scoreAmount += persec * Time.deltaTime;  // adding the  the initial score with multiplication of the multiplier and the deltatime 
        //Debug.Log(Time.deltaTime);
        
    }
}
