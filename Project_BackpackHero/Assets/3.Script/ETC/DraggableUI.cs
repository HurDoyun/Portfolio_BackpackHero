using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    //private float speed = 3f;

    //public float rotateSpeed = 3f;
    //private float t;

    public float rotationAmount = 90f;

    [HideInInspector] public Transform parentAfterDrag;

    private void Update()
    {
        if (Input.GetMouseButton(0)) //마우스 왼쪽으로 든 채로 마우스 오른쪽으로 90도씩 회전
        {
            if (Input.GetMouseButtonDown(1))
            {
                transform.Rotate(new Vector3(0, 0, rotationAmount));
            }
        }

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}
