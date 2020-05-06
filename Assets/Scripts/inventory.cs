using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    public Queue<Item> items;
    public Text uitext;
    public int max = 10;
    private void Start()
    {
        items = new Queue<Item>();
    }
    public void AddItem(Item item)
    {
        if (items.Count == max)
        {
            return;
        }
        else
        {
            items.Enqueue(item);
            item.Consume();
        }
        RefreshUI();
    }
    public void RefreshUI()
    {
        uitext.text = "";
        foreach (Item i in items)
        {
            uitext.text += i.label + "\n";
        }
    }
    public Item Use()
    {
        if (items.Count == 0)
            return null;
        Item tmp = items.Dequeue();
        RefreshUI();
        return tmp;
    }
}
