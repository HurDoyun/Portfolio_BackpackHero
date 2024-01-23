using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCont : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Background_move()
    {
        anim.SetTrigger("Moving");
        Invoke("Background_stop", 1f);
    }
    public void Background_stop()
    {
        anim.SetTrigger("Stop");
    }
}
