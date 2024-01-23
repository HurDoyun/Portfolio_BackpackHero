using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
   public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0) //칸에 넣을 수 있는 아이템을 중복시키지 않기 위함
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableUI draggable_ui = dropped.GetComponent<DraggableUI>();
            draggable_ui.parentAfterDrag = transform;
        }
        
    }
}
