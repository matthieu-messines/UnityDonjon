using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour {

    private bool spawn;
    public GameObject Enemy;

	// Use this for initialization
	void Start () {
        spawn = false;	
	}
	
	// Update is called once per frame
	void Update () {
        if (spawn)
        {
            Instantiate(Enemy,transform.position,transform.rotation);
            SetSpawn(true);
            Destroy(gameObject);
        }
	}

    public void SetSpawn(bool NewSpawn)
    {
        spawn = NewSpawn;
    }
}
