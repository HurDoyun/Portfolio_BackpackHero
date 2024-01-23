using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagBtn : MonoBehaviour
{
    private Animator anim;
    private PlayerCont player;

    private void Start()
    {
        anim = GetComponent<Animator>();

        player = FindObjectOfType<PlayerCont>();
    }
    public void Openbag()
    {
        anim.SetBool("OpenBag", true);
    }
    public void Closebag()
    {
        anim.SetBool("OpenBag", false);
    }
}
