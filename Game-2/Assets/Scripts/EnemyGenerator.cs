using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //Enemy respawn time
    [SerializeField]
    private float nextSpawnTime;

    public float[] positionX;


    void Awake(){
      
        
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MyCoroutine");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Enemy Generator
    private void EnemyGenerate()
    {   
        //Getting a Enemy object from ObjectPooler and assiging it to "newEnemy"
        int r = Random.Range(0,5);
        string enemyName = "";
        if(r == 0) enemyName = "Earth_Enemy";
        if(r == 1) enemyName = "Fire_Enemy";
        if(r == 2) enemyName = "Lightning_Enemy";
        if(r == 3) enemyName = "Water_Enemy";
        if(r == 4) enemyName = "Wind_Enemy";
        //Debug.Log(r);
        
        GameObject newEnemy = (GameObject)ObjectPooler.SharedInstance.GetPooledObject(enemyName);
        if(newEnemy != null){
            Debug.Log(positionX[1]);
            newEnemy.transform.position = new Vector2(positionX[Random.Range(0,positionX.Length)], 6.0f);
            newEnemy.SetActive(true);
        }
        
    }


    //Coroutine function for generating enemy
    IEnumerator MyCoroutine()
    {
        for (; ; )
        {
            EnemyGenerate();
            yield return new WaitForSeconds(nextSpawnTime);
        }
    }

}
