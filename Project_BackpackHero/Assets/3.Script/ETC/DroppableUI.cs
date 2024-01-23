using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI : MonoBehaviour, IPointerEnterHandler, IDropHandler, IPointerExitHandler
{
    private Image image;
    private RectTransform rect;
    private void Awake()
    {
        image = GetComponent<Image>();
        rect = GetComponent<RectTransform>();
    }

    public void OnPointerEnter(PointerEventData evenData)
    {
        
    }//���콺 �����Ͱ� ���� ������ ���� ���� ���η� �� �� 1ȸ ȣ��
    public void OnPointerExit(PointerEventData eventData)
    {
       
    }//���콺 �����Ͱ� ���� ������ ���� ������ �������� �� 1ȸ ȣ��
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        //pointerDrag�� ���� �巡�� �ϰ� �ִ� ���
        {
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;

        }
    }//���� ������ ���� ���� ���ο��� ����� ���� �� 1ȸ ȣ��
}
