using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapBtn : MonoBehaviour
{
    private Animator anim;
    private PlayerCont player;
    private GridCont grid;

    private void Start()
    {
        anim = GetComponent<Animator>();

        player = FindObjectOfType<PlayerCont>();
        grid = FindObjectOfType<GridCont>();
    }
    public void MapRead()
    {
        anim.SetBool("Read", true); //지도 열림
    }
    public void MapClose()
    {
        anim.SetBool("Read", false);
    }
    public void MapBtn_coin()
    { 
        player.Walk();
    }
    public void MapBtn_enemy()
    {
        player.Walk();
    }

    public void MapBtn_stair()
    {

    }
    
}
