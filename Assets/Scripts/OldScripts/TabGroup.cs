using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabsButtons;
    public Sprite tabIdle;
    public Sprite tabHover;
    public Sprite tabActive;
    public TabButton selectedTab;
    public List<GameObject> objectsToShow;

    public void Subscribe(TabButton button)
    {
        if(tabsButtons == null)
        {
            tabsButtons = new List<TabButton>();
        }

        tabsButtons.Add(button);
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if(selectedTab == null || button != selectedTab)
        {
            button.backgroundB.sprite = tabHover;
        }
    }

    public void OnTabExit(TabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button)
    {
        if(selectedTab != null)
        {
            selectedTab.Deselect();
        }

        selectedTab = button;

        selectedTab.Select();

        ResetTabs();
        button.backgroundB.sprite = tabActive;

        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToShow.Count; i++) 
        {
            if (i == index)
            {
                objectsToShow[i].SetActive(true);
            }
            else
            {
                objectsToShow[i].SetActive(false);
            }
        }
    }

    public void ResetTabs()
    {
        foreach(TabButton button in tabsButtons)
        {
            if (selectedTab != null && button == selectedTab)  
            {
                continue;
            }
            button.backgroundB.sprite = tabIdle;
        }
    }
}
