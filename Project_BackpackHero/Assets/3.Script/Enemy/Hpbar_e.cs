using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar_e : MonoBehaviour
{
    [SerializeField] private Slider Hpbar;
    [SerializeField] private EnemyCont enemy;
    private void Start()
    {
        Hpbar = GetComponent<Slider>();
        enemy = FindObjectOfType<EnemyCont>();
    }
    private void Update()
    {
        Hpbar.value = enemy.curhp / enemy.maxhp;
    }
}
