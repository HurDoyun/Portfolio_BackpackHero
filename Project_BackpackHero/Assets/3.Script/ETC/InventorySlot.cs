using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
   public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0) //ĭ�� ���� �� �ִ� �������� �ߺ���Ű�� �ʱ� ����
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableUI draggable_ui = dropped.GetComponent<DraggableUI>();
            draggable_ui.parentAfterDrag = transform;
        }
        
    }
}
