using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatButton : MonoBehaviour
{
    private PlayerCont player;
    [SerializeField] private EnemyCont enemy;
    private FightManager fight;
    public bool click = false;
    private void Start()
    {
        player = FindObjectOfType<PlayerCont>();
        enemy = FindObjectOfType<EnemyCont>();
        fight = FindObjectOfType<FightManager>();
    }
    public void OnClick()
    {
        if (fight.playerTurn)
        {
            player.EatMotion();
        }
    }
}
