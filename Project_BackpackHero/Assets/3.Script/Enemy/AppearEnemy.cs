using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AppearEnemy : MonoBehaviour
{
    private SpriteRenderer sr;
    //private Image image;
    private Animator anim;

    //private bool mouseOn = false;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        //image = GetComponent<Image>();
        anim = GetComponent<Animator>();

        sr.color = new Color(1, 1, 1, 0f);
        //image.color = new Color(1, 1, 1, 0f);
    }

    public void Willbox()
    {
        Invoke("Cansee", 1.3f);
        //mouseOn = true;
    }
    public void Cansee()
    {
        sr.color = new Color(1, 1, 1, 1);

        Invoke("SceneLoader", 1.3f);
    }
    public void SceneLoader()
    {
        SceneManager.LoadScene(3);
    }

}
