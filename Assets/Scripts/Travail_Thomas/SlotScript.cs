using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IDropHandler
{
    public int[,] grid;
    public int slotID;

    void Start()
    {
        grid = new int[5, 4];
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");

        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }

    }
}
