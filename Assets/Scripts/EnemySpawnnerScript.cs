using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnnerScript : MonoBehaviour {

    public GameObject EnemySpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            EnemySpawn.GetComponent<EnemySpawnScript>().SetSpawn(true);
            Destroy(gameObject);
        }
    }
}
