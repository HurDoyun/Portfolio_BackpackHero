using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpTxt_e : MonoBehaviour
{
    [SerializeField] private Text hpTxt;
    [SerializeField] private EnemyCont enemy;
    private void Start()
    {
        enemy = FindObjectOfType<EnemyCont>();
    }
    private void Update()
    {
        hpTxt.text = $"{enemy.curhp}/{enemy.maxhp}";
    }
}
