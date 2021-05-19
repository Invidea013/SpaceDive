using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IDropHandler
{
    public GameObject pipeLinked;
    public int slotID = 0;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");

        if (eventData.pointerDrag != null && pipeLinked == null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;

            pipeLinked = eventData.pointerDrag.GetComponent<RectTransform>().gameObject;

        }
        else if (pipeLinked != null && pipeLinked != eventData.pointerDrag.GetComponent<RectTransform>().gameObject)
        {
            pipeLinked.GetComponent<DragAndDrop>().ResetPosition();
            pipeLinked = eventData.pointerDrag.GetComponent<RectTransform>().gameObject;
        }
        else
        {
            eventData.pointerDrag.GetComponent<DragAndDrop>().ResetPosition();
        }



    }
}
