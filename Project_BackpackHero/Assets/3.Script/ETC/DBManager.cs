using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour
{
    static public DBManager instance;
    private void Awake()
    {
        if (instance != null) //�̹� DBManager �ν��Ͻ��� �����Ѵٸ� ������Ʈ�� �ı��ؼ� �ߺ��� �ν��Ͻ��� ����
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject); //���� �ν��Ͻ��� ���� �������� �ʾҴٸ� �ı����� �ʰ� ������ �ν��Ͻ��� ����.
            instance = this;
        }


    }
}

