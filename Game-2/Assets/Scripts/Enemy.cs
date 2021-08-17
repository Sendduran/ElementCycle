using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Enemy : MonoBehaviour
{

    private float speed = 1.5f;
    public GameObject[] enemyList;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * speed * Time.deltaTime);

        //if (transform.position.y < -5) {

        //    float randomX = Random.Range(-2, 2);
        //    Debug.Log("im out");
        //    transform.position = new Vector3( randomX, 6,0);
        //}
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        

        if (other.tag == "wall")
        {
            //Debug.Log("i got collide");

            Wall wall = other.GetComponent<Wall>();

            if (wall != null) {

                wall.Damage(); //calling the Damange Method from Wall Componenet 
            }

            
            this.gameObject.SetActive(false);

        }


    }



    public void disableEnemy()
    {

        Debug.Log(this.name);
        //Debug.Log(GameObject.Find("Earth_Enemy"));
        //int num = GameObject.FindGameObjectsWithTag("earthEnemy").Length;
        //enemy = GameObject.FindGameObjectsWithTag("earthEnemy");
        try {
          
            enemyList = GameObject.FindGameObjectsWithTag("earthEnemy");
            
            foreach (GameObject enemyObject in enemyList)
            {
                enemyObject.SetActive(false);
            }

        }

        catch (Exception ex) {
            Debug.Log("errror is");
        }


     





    }

}
