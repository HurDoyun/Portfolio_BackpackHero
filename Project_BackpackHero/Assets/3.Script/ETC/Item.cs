using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item //ĭ ����ε� ������ ������
{
    #region �⺻ ������ ���� ����
    /* ������ �̸� ��-�Ļ�
    * ������ ��� ��-ȥ��
    * ��� Ƚ�� ��-2��
    * � �������� ��-�Ҹ�ǰ
    * ����(���� � ȿ��) ��-�������� 2��ŭ ����ϴ�.
    * ��� Ƚ���� ���� �� ��-�ı���
    * 
    * ������ �̸� - ���
    * ��� -ȥ��
    * Ƚ�� =����
    * � ����? -����
    * ���� - 7�� ���ظ� �����ϴ�.
    * Ƚ���� ���� �� -����
    * 
    * ������ �̸� - ��ģ ��Ŭ��
    * ��� - ȥ��
    * Ƚ�� - ����
    * � ����? - ����
    * ���� - �� 7 �߰��մϴ�.
    * 
    * 
    */
    #endregion

    public int itemId;
    public string itemName;
    public string itemRank;
    public string itemEffect; //���� ȿ��
    public bool isConsum; //�Ҹ�ǰ�ΰ���?
    //public int itemUseNum; //���Ƚ��
    public string afterUseNum; //���Ƚ�� ���� ��
    //public Sprite itemIcon;
    public ItemType itemtype;
    public Space space;

    public enum ItemType
    {
       weapon = 0, defenser, food, etc
    }
    public enum Space
    {
        one = 10, two_row, two_col, three_row, three_col, four
    }

    public Item(int itemId, string itemName, string itemRank, string itemEffect, bool isConsum, string afterUseNum, Space space, ItemType itemType)
    {
        this.itemId = itemId;
        this.itemName = itemName;
        this.itemRank = itemRank;
        this.itemEffect = itemEffect;
        this.isConsum = isConsum;
        //this.itemUseNum = itemUseNum;
        this.afterUseNum = afterUseNum;
        this.space = space;
        this.itemtype = itemType;

        //itemIcon = Resources.Load(itemId.ToString(), typeof(Sprite)) as Sprite;
    }
}
   

