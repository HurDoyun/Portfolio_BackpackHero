using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestOn : MonoBehaviour
{
    private SpriteRenderer sr;
    private Animator anim;
    public bool mouseOn = false;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        sr.color = new Color(1, 1, 1, 0f);
    }
    public void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Unlock();

            Invoke("OnDestroy", 1f);
        }
        
    }
    public void Willbox()
    {
        Invoke("Appear", 1.3f);
        
    }
    private void Appear()
    {
        sr.color = new Color(1, 1, 1, 1);
        
    }
    public void Unlock()
    {
        anim.SetTrigger("BoxOn"); //박스가 열리는 거
        mouseOn = true;
    }
    public void OnDestroy()
    {
        Destroy(this.gameObject);
        
    }
}
