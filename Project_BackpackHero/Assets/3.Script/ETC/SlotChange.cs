using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotChange : MonoBehaviour
{
    [SerializeField] private GridLayoutGroup gridLayout;
    private float x, y;
    private int coco;

    private void Start()
    {
        gridLayout.cellSize = new Vector2(x, y);
    }
    private void Update()
    {
        if (true)
        {
            x = 160;
            y = 160;

            Debug.Log("��ĭ¥�� ������ ����");

            gridLayout.cellSize = new Vector2(x, y);
            gridLayout.constraintCount = coco;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (true) //���� ��ĭ ¥�� �������� ��´ٸ�
        {
            x = 80;
            y = 80;

            Debug.Log("��ĭ¥�� ������ ����");
    
            gridLayout.cellSize = new Vector2(x, y);
            gridLayout.constraintCount = coco;
        }
    }
}
