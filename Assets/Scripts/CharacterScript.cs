using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

    public int pvMax;
    public int pvCurrent;

    public void Damage(int i)
    {
        pvCurrent -= i;
    }

    public void Remove()
    {
        Destroy(gameObject);
    }

    public int GetPvCurrent()
    {
        return pvCurrent;
    }

}
