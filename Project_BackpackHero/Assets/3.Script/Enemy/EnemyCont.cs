using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCont : MonoBehaviour
{
    private PlayerCont player;
    [SerializeField] private FightManager fight;

    //private Rigidbody2D rd;
    private SpriteRenderer sr;
    private Animator anim;

    public float curhp = 32f;
    public float maxhp;
    private float defPower;

    //public bool atk = false;
    //public bool shield = false;

    private void Start()
    {
        //rd = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        player = FindObjectOfType<PlayerCont>();
        fight = FindObjectOfType<FightManager>();

        curhp = maxhp;
    }
    private void Update()
    {
        if (fight.enemyTurn)
        {
            Act();
        }
    }
    public void Act()
    {
        int what_act = Random.Range(0, 2); //���� �ൿ ����
        int How_much = Random.Range(0, 10); //�Ŀ��� �󸸰���

        if (what_act == 0)
        {
            //�� ���� ��� + �÷��̾� �ǰ� ��´�.
            //�÷��̾ ������� ��� �� ��� - �� ���� = �������� �ǰ�
            Debug.Log("���� ��������");
            AtkMotion_E();
            player.HurtMotion();
            //�÷��̾� Ÿ�� �ִϸ��̼� + hpbar
            player.curhp -= How_much;

            fight.enemyTurn = false;
        }
        if (what_act == 1)
        {
            //�� ��� ��� + ���� hp�� ������ �ȵ�
            //�÷��̾ �������� ��� �� ��� - �� ���� = �������� �ǰ�
            Debug.Log("���� �������");
            Debug.Log($"{defPower}");
            BlockMotion_E();

            fight.enemyTurn = false;
        }
    }
    public void HurtMotion()
    {
        curhp -= player.atkPower;
        sr.color = new Color(1, 1, 1, 0.4f);
        Invoke("OriColor", 0.5f);
    }
    public void OriColor()
    {
        sr.color = new Color(1, 1, 1, 1);

    }
    public void OnDie()
    {
        Destroy(this.gameObject);
        player.WinMotion();
    }
    public void AtkMotion_E()
    {
        anim.SetTrigger("E_Atk");
        Invoke("BackIdle", 0.5f);

        if (player.curhp <= 0)
        {
            player.OnDie();
        }
    }
    public void BlockMotion_E()
    {
        anim.SetTrigger("E_block");
        Invoke("BackIdle", 0.5f);
    }
    public void BackIdle()
    {
        anim.SetTrigger("ReIdle");
    }
}
