using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FightManager : MonoBehaviour
{
    //static public FightManager instance;

    private PlayerCont player;
    private EnemyCont enemy;

    [SerializeField] private AtkButton atkbtn;
    [SerializeField] private DefButton defbtn;
    [SerializeField] private EatButton eatbtn;
    [SerializeField] private TurnEndButton turnend;

    [SerializeField] private Logos logos;

    public bool playerTurn;
    public bool enemyTurn;

    public bool isLive;
    public int fight_count;

    private void Awake()
    {
        player = FindObjectOfType<PlayerCont>();
        enemy = FindObjectOfType<EnemyCont>();

        atkbtn = FindObjectOfType<AtkButton>();
        defbtn = FindObjectOfType<DefButton>();
        eatbtn = FindObjectOfType<EatButton>();
        turnend = FindObjectOfType<TurnEndButton>();

        logos = FindObjectOfType<Logos>();

        BettleStart();

    }
    public void BettleStart()
    {
        logos.StartLogoOn();
        playerTurn = true;
    }
    public void PlayerBtn()
    {
        if (!playerTurn)
        {
            return;
        }
        else
        {
            logos.PlayerLogoOn();
            StartCoroutine(Player_Act());
        }
    }
    IEnumerator Player_Act()
    {

        yield return new WaitForSeconds(0.5f);

        if (atkbtn.click)
        {
            atkbtn.OnClick();

        }
        else if (defbtn.click)
        {
            defbtn.OnClick();
        }
        else if (eatbtn.click)
        {
            eatbtn.OnClick();
        }

        if (enemy.curhp <= 0)
        {
            player.WinMotion();
        }
        else
        {
            enemyTurn = true;
            StartCoroutine(Enemy_Act());
        }
    }
    IEnumerator Enemy_Act()
    {
        //UI --- �� ����!
        yield return new WaitForSeconds(0.5f);

        //�� ���� �ڵ�
        enemy.Act();

        playerTurn = true; //�� ���� �������� �÷��̾�� �� �ѱ��
    }

}
