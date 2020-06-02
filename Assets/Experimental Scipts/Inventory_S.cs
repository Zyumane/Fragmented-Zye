using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_S : MonoBehaviour
{
    [SerializeField]
    private int _slots = 9;

    [SerializeField]
    private List<IInventoryItem> mini_items = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArgs> itemAdded;


    public void Additem(IInventoryItem item)
    {
        if(mini_items.Count < _slots)
        {
            Collider col = (item as MonoBehaviour).GetComponent<Collider>();
            if(col.enabled)
            {
                col.enabled = false;

                mini_items.Add(item);

                item.OnPickup();

                if(itemAdded != null)
                {
                    itemAdded(this, new InventoryEventArgs(item));
                }
            }
        }
    }



    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
