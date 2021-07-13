using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public int Health = 50;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage() {

        Health = Health - 10;
        //Debug.Log(Health);
        if (Health < 1) {

            Destroy(this.gameObject);
            Debug.Log("game over");
        
        }
    
    
    }

 


}
