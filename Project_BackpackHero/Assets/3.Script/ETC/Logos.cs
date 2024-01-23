using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logos : MonoBehaviour
{
    [SerializeField] private Image startLogo;
    [SerializeField] private Image playrLogo;
    [SerializeField] private Image enemyLogo;

    public void StartLogoOn()
    {
        startLogo.gameObject.SetActive(true);
        playrLogo.gameObject.SetActive(false);
        enemyLogo.gameObject.SetActive(false);
    }
    public void PlayerLogoOn()
    {
        startLogo.gameObject.SetActive(false);
        playrLogo.gameObject.SetActive(true);
        enemyLogo.gameObject.SetActive(false);
    }
    public void EnemyLogoOn()
    {
        startLogo.gameObject.SetActive(false);
        playrLogo.gameObject.SetActive(false);
        enemyLogo.gameObject.SetActive(true);
    }

}
