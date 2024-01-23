using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemAnimation : MonoBehaviour
{
    //private Animator anim;
    private Image image;
    private ChestOn chest;
    
    private void Start()
    {
        //anim = GetComponent<Animator>();
        image = GetComponent<Image>();
        chest = FindObjectOfType<ChestOn>();
    }
    private void Update()
    {
        if (chest.mouseOn)
        {
            image.color = new Color(1, 1, 1, 1);
        }
        else
        {
            image.color = new Color(1, 1, 1, 0f);
        }
    }
    
}
