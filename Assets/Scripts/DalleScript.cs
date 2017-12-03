using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DalleScript : MonoBehaviour {

    public LanceScript Lance;
    private Vector3 LancePosition;
    private Quaternion LanceRotation;
    public LanceScript PrefabLance;

    void Start()
    {
        Lance = GetComponentInChildren<LanceScript>();
        LancePosition = Lance.transform.position;
        LanceRotation = Lance.transform.rotation;
    }

	void OnTriggerEnter(Collider c)
    {
        if (!Lance.GetIsMoving() && (c.tag == "Player" || c.tag == "Enemy")){
            Lance.Use();
        }
    }

    void Update()
    {
        if (Lance == null)
        {
            Lance = Instantiate(PrefabLance,LancePosition,LanceRotation);
            Lance.transform.parent = gameObject.transform;
        }
    }
}
