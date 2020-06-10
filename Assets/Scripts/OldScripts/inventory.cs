using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CardFragment
{
    Fragment_A = 0,
    Fragment_B = 1,
    Fragment_C = 2,
    Fragment_D = 3,
    Fragment_E = 4
}

public enum Card_Compl
{
    Completed = 0,
    Incompleted = 1
}

public enum Deck
{
    Card_no_1   = 0, 
    Card_no_2   = 1,
    Card_no_3   = 2,
    Card_no_4   = 3,
    Card_no_5   = 4,
    Card_no_6   = 5,
    Card_no_7   = 6,
    Card_no_8   = 7,
    Card_no_9   = 8,
    Card_no_10  = 9,
    Card_no_11  = 10,
    Card_no_12  = 11,
    Card_no_13  = 12,
    Card_no_14  = 13,
    Card_no_15  = 14,
    Card_no_16  = 15,
    Card_no_17  = 16,
    Card_no_18  = 17,
    Card_no_19  = 18,
    Card_no_20  = 19,
    Card_no_21  = 20,
    Card_no_22  = 21,
    Card_no_23  = 22,
    Card_no_24  = 23,
    Card_no_25  = 24,
    Card_no_26  = 25,
    Card_no_27  = 26,
    Card_no_28  = 27,
    Card_no_29  = 28,
    Card_no_30  = 29,
    Card_no_31  = 30,
    Card_no_32  = 31,
    Card_no_33  = 32,
    Card_no_34  = 33,
    Card_no_35  = 34,
    Card_no_36  = 35,
    Card_no_37  = 36,
    Card_no_38  = 37,
    Card_no_39  = 38,
    Card_no_40  = 39,
    Card_no_41  = 40,
}   //son cartas para identificar

[System.Serializable]
public class Frag_Qua_Card
{
    public CardFragment cardFrag;
    public int          quanti;
    public bool[]       idfrag;
    public Deck         numOfCard;
    public Card_Compl   Complt;
}

[System.Serializable]
public class Qua_frag_converter
{
    public Frag_Qua_Card matQuaA;
    public Frag_Qua_Card matQuaB;
    public Frag_Qua_Card matQuaC;
    public Frag_Qua_Card matQuaD;
    public Frag_Qua_Card matQuaE;
}


public class inventory : MonoBehaviour
{
    public Queue<Item> items;
    public List<Frag_Qua_Card> Frag_s;
    public Text uitext;
    public int max = 10;

    public TabGroup Tab;
    public TabGroup btn;

    public Qua_frag_converter[] Qua_Frag_s;
    public Frag_Qua_Card[] frag_Quas;

    private void Start()
    {
        items = new Queue<Item>();
        Frag_s = new List<Frag_Qua_Card>();
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
