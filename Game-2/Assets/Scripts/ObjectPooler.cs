using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {

	public static ObjectPooler SharedInstance; 


    public ObjectPoolItems[] itemsToPool;
    private List<GameObject> pooledObjects;


	void Awake()
	{
        if(SharedInstance == null){
            SharedInstance = this;
        }

        pooledObjects = new List<GameObject>();

        foreach(ObjectPoolItems item in itemsToPool){

            for(int i = 0; i < item.poolAmount; i++){
                GameObject obj = (GameObject)Instantiate(item.poolObject);
                obj.name = item.name;
                obj.transform.parent = this.transform;
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }
		
	}
	
	// Use this for initialization

	void Start () {	
        
    }
    

    public GameObject GetPooledObject(string name){
        //Debug.Log(pooledObjects.Count);

        for(int i = 0; i < pooledObjects.Count; i++){

            if(pooledObjects[i].activeInHierarchy == false && pooledObjects[i].name == name){
                

                return pooledObjects[i];
            }

            foreach(ObjectPoolItems item in itemsToPool){

                if(item.poolObject.name == name){

                    GameObject obj = (GameObject)Instantiate(item.poolObject);
                    obj.name = item.name;
                    obj.transform.parent = this.transform;
                    obj.SetActive(false);
                    pooledObjects.Add(obj);
                    return obj;
                }
            }
        }
        return null;
    }

    
    [System.Serializable]
    public class ObjectPoolItems {
        public string name;
        public int poolAmount;
        public GameObject poolObject;
        public bool shouldExpand = true;
    }

}