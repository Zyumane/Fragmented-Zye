using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public enum ItemType
    {
        EXP = 0,
        HEART = 1,
        POTION = 2,
        FRAGMENT = 3
    }
    public ItemType type;
    public string label;
    public int fragmentid;
    public void Consume()
    {
        gameObject.SetActive(false);
    }

}
