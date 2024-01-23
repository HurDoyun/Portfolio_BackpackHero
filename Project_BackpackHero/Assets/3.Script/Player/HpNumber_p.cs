using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpNumber_p : MonoBehaviour
{
    [SerializeField] private Text hpTxt;
    [SerializeField] private PlayerCont player;
    private void Start()
    {
        player = FindObjectOfType<PlayerCont>();
    }
    public void Number_Atked()
    {
        hpTxt.text = $"-{player.maxhp - player.curhp}";
    }
}
