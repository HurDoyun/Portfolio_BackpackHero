using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item //칸 수대로도 아이템 나눴음
{
    #region 기본 아이템 정보 예시
    /* 아이템 이름 예-식사
    * 아이템 등급 예-혼합
    * 사용 횟수 예-2번
    * 어떤 물건인지 예-소모품
    * 사용시(사용시 어떤 효과) 예-에너지를 2만큼 얻습니다.
    * 사용 횟수가 고갈될 시 예-파괴됨
    * 
    * 아이템 이름 - 목검
    * 등급 -혼합
    * 횟수 =없음
    * 어떤 물건? -없음
    * 사용시 - 7의 피해를 입힙니다.
    * 횟수가 고갈될 시 -없음
    * 
    * 아이템 이름 - 거친 버클러
    * 등급 - 혼합
    * 횟수 - 없음
    * 어떤 물건? - 없음
    * 사용시 - 방어를 7 추가합니다.
    * 
    * 
    */
    #endregion

    public int itemId;
    public string itemName;
    public string itemRank;
    public string itemEffect; //사용시 효과
    public bool isConsum; //소모품인가요?
    //public int itemUseNum; //사용횟수
    public string afterUseNum; //사용횟수 고갈될 때
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
   

