using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour
{

    public int Health = 50;
    public Slider healthBar;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = Health;
    }

    public void Damage() {

        
        Health = Health - 10;
        //Debug.Log(Health);
        if (Health < 1) {
            healthBar.value = 0;
            Destroy(this.gameObject);
            Debug.Log("game over");
        
        }
    
    
    }

 


}
