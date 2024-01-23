using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnEndButton : MonoBehaviour
{
    private PlayerCont player;
    [SerializeField] private EnemyCont enemy;
    [SerializeField] private FightManager fight;
    private ButtonManager btnManager;
    private Logos logos;
    private void Start()
    {
        player = FindObjectOfType<PlayerCont>();
        enemy = FindObjectOfType<EnemyCont>();
        fight = FindObjectOfType<FightManager>();
        btnManager = FindObjectOfType<ButtonManager>();
        logos = FindObjectOfType<Logos>();
    }
    public void OnClick()
    {
        Debug.Log("차례 종료");//플레이어 행동버튼 눌러도 정지되게 만들기
        if (fight.playerTurn) //플레이어 턴일 때
        {
            logos.EnemyLogoOn();
            
            fight.enemyTurn = true;
            btnManager.Reset();
        }
    }
}
