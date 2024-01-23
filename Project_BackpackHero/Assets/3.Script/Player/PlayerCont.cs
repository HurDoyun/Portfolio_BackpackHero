using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCont : MonoBehaviour
{
    [SerializeField] private FightManager fight;
    [SerializeField] public Text actCount;
    [SerializeField] public Text _exp;
   
    private Rigidbody2D rd;
    private SpriteRenderer sr;
    public Animator anim;

    public float curhp = 40f;
    public float maxhp;
    public int energy = 3; //매 턴마다 3
    public float defPower;
    public float atkPower;
    public float exp;
    public float NextLv = 30;

    public float speed = 10f;

    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        fight = FindObjectOfType<FightManager>();

        curhp = maxhp;
        actCount.text = $"{energy}";
        _exp.text = $"경험치 : {exp} / {NextLv}";
    }

    public void WinMotion()
    {
        Debug.Log("적을 물리쳤습니다!");
        anim.SetTrigger("Winer");
        exp = 7;
        _exp.text = $"경험치 : {exp} / {NextLv}";

    }
    public void AtkMotion()
    {
        Debug.Log("플레이어 공격!!!");
        atkPower = 7;
        energy -= 1;
        actCount.text = $"{energy}";
        anim.SetTrigger("Atking");
        Invoke("BackIdle", 0.5f);

    }
    public void BlcokMotion()
    {
        Debug.Log("방어 버튼!!!");
        defPower = 7;
        energy -= 1;
        actCount.text = $"{energy}";
        anim.SetTrigger("Blocking");
        Invoke("BackIdle", 0.5f);
    }
    public void EatMotion()
    {
        Debug.Log("냠냠");
        energy += 2;
        actCount.text = $"{energy}";

        anim.SetTrigger("Eating");
        Invoke("BackIdle", 0.5f);
    }
    public void HurtMotion()
    {
        anim.SetTrigger("Ooch");
        Invoke("BackIdle", 0.5f);
    }
    public void BackIdle()
    {
        anim.SetTrigger("ReIdle");
    }
    public void OnDie()
    {
        anim.SetTrigger("YouDie");
        Debug.Log("당신은 죽었습니다...");
    }
    public void Walk()
    {
        anim.SetTrigger("Walking");
        Invoke("BackIdle", 1f);
    }

}
