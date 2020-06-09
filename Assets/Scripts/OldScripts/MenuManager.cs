using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject completeCard;
    public int allSlots;
    public int enabledSlots;
    public GameObject slotHolder;
    public bool displayMenu;

    [SerializeField]
    private List<GameObject> slots;

    // Start is called before the first frame update
    void Start()
    {
        allSlots = 40;

        slots = new GameObject(allSlots);

        for (int i = 0; i < allSlots; i++)
        {
            slots[i] = slotHolder.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            displayMenu = !displayMenu;
        }

        if(displayMenu == true)
        {
            completeCard.SetActive(true);
        }
        else
        {
            completeCard.SetActive(false);
        }
    }
}
