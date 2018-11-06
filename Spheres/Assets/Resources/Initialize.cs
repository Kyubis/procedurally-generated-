using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize : MonoBehaviour {

    public Transform sphere; //Object to spawn
    public float objectPressure; 
    public int objectPoolSize;


	void Start () {

        //Object spawner
		for (int i = 0; i< objectPoolSize; i++)
        {
            Instantiate(sphere, new Vector3(Random.Range(-objectPressure, objectPressure), Random.Range(-objectPressure, objectPressure), Random.Range(-objectPressure, objectPressure)), Quaternion.identity);
        }
	}
	
}
