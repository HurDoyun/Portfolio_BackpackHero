using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar_p : MonoBehaviour
{
    [SerializeField] private Slider Hpbar;
    [SerializeField] private PlayerCont player;
    private void Start()
    {
        Hpbar = GetComponent<Slider>();
        player = FindObjectOfType<PlayerCont>();
    }
    private void Update()
    {
        Hpbar.value = player.curhp / player.maxhp;
    }
}
