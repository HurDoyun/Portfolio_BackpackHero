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
        int what_act = Random.Range(0, 2); //다음 행동 예고
        int How_much = Random.Range(0, 10); //파워가 얼만가요

        if (what_act == 0)
        {
            //적 공격 모션 + 플레이어 피가 닳는다.
            //플레이어가 방어했을 경우 플 방어 - 적 공격 = 나머지만 피격
            Debug.Log("적이 공격했음");
            AtkMotion_E();
            player.HurtMotion();
            //플레이어 타격 애니메이션 + hpbar
            player.curhp -= How_much;

            fight.enemyTurn = false;
        }
        if (what_act == 1)
        {
            //적 방어 모션 + 적의 hp가 변동이 안됨
            //플레이어가 공격했을 경우 적 방어 - 플 공격 = 나머지만 피격
            Debug.Log("적이 방어했음");
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
