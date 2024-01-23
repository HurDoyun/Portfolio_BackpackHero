using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkButton : MonoBehaviour
{
    private PlayerCont player;
    [SerializeField] private EnemyCont enemy;
   
    private FightManager fight;
    public bool click = false;
    private AtkButton btn;
    private void Start()
    {
        player = FindObjectOfType<PlayerCont>();
        enemy = FindObjectOfType<EnemyCont>();
        fight = FindObjectOfType<FightManager>();  

        //if (!fight.playerTurn)
        //{
        //    btn.gameObject.SetActive(false);
        //}

    }
    public void OnClick()//�÷��̾�cs�� ��cs�� �Լ����� ���� ������
    {
        if (fight.playerTurn)
        {
            player.AtkMotion();
            enemy.HurtMotion();
        }
        
        if(enemy.curhp <= 0)
        {
            player.WinMotion();
            enemy.OnDie();
            
            //Debug.Log("��ư ������ �� ������");
        }
    }
    
    
}
