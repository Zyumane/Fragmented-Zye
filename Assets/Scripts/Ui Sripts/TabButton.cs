using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public TabGroup tabGrouper;

    public Image backgroundB;

    public UnityEvent OnTabSelected;
    public UnityEvent OnTabDeselected;

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGrouper.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGrouper.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGrouper.OnTabExit(this);
    }

    void Start()
    {
        backgroundB = GetComponent<Image>();
        tabGrouper.Subscribe(this);
    }

    public void Select()
    {
        if (OnTabSelected != null)
        {
            OnTabSelected.Invoke();
        }
    }
    public void Deselect()
    {
        if (OnTabDeselected != null)
        {
            OnTabDeselected.Invoke();
        }
    }
}
