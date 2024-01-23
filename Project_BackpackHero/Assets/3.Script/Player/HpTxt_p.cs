using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpTxt_p : MonoBehaviour
{
    [SerializeField] private Text hpTxt;
    [SerializeField] private PlayerCont player;
    private void Start()
    {
        player = FindObjectOfType<PlayerCont>();
    }
    private void Update()
    {
        hpTxt.text = $"{player.curhp}/{player.maxhp}";
    }
}
