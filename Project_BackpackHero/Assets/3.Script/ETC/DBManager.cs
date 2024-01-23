using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour
{
    static public DBManager instance;
    private void Awake()
    {
        if (instance != null) //이미 DBManager 인스턴스가 존재한다면 오브젝트를 파괴해서 중복된 인스턴스를 방지
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject); //만약 인스턴스가 아직 설정되지 않았다면 파괴하지 않고 현재의 인스턴스로 설정.
            instance = this;
        }


    }
}

