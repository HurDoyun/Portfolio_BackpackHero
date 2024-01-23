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
        Debug.Log("���� ����");//�÷��̾� �ൿ��ư ������ �����ǰ� �����
        if (fight.playerTurn) //�÷��̾� ���� ��
        {
            logos.EnemyLogoOn();
            
            fight.enemyTurn = true;
            btnManager.Reset();
        }
    }
}
