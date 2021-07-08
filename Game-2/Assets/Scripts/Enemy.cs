using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private float speed = 3.0f;

    

   
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
            Debug.Log("i got collide");

            Wall wall = other.GetComponent<Wall>();

            if (wall != null) {

                wall.Damage(); //calling the Damange Method from Wall Componenet 
            }

            Destroy(this.gameObject);

        }


    }


}
