using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaItem : MonoBehaviour
{
    [SerializeField]
    private int _fragted_piece = 3;

    public bool[] fragments;

    public MegaItem()
    {
        fragments = new bool[_fragted_piece];
    }

    public void AddFragment(Item i)
    {
        fragments[i.fragmentid] = true;
    }

    public bool Completed()
    {
        bool flag = true;
        foreach (bool frament in fragments)
            flag = flag && frament;
        return flag;
    }

    public bool MegaitemComplete()
    {
        if (!Completed())
        {
            //ui
            Debug.Log("Cook ");
            return false;
        }

        Debug.Log("bloop ");
        GameObject.CreatePrimitive(PrimitiveType.Cube);
        
        return true;
    }
}
