using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : CharacterScript {

    private int degats = 1;
    private GameObject player;
    private NavMeshAgent nav;
    void Start()
    {
        player = GameObject.Find("Player");
        nav = GetComponent<NavMeshAgent>();
        pvCurrent = pvMax = 1;
    }

	void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Player")
        {
            c.gameObject.GetComponent<PlayerScript>().Damage(degats);
        }
    }

    void Update()
    {
        //transform.LookAt(player.transform);
        //transform.Translate(new Vector3(0, 0, 0.05f));
        nav.SetDestination(player.transform.position);
        if (GetPvCurrent() <= 0)
        {
            base.Remove();
        }
    }
}
