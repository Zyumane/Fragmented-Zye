using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaItem : MonoBehaviour
{
    public bool[] fragments;
    public MegaItem()
    {
        fragments = new bool[4];
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
    public bool SpecialAction()
    {
        if (!Completed())
            return false;

        /*
         * Accion especial
         */


        return true;
    }
}
