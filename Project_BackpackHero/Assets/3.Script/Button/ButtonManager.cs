using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] public Button[] buttons;
    [SerializeField] private TurnEndButton endbtn;

    private PlayerCont player;

    private int clickCount = 0;

    private void Start()
    {
        player = FindObjectOfType<PlayerCont>();
        endbtn = FindObjectOfType<TurnEndButton>();

        for (int i = 0; i < buttons.Length; i++)
        {
            int buttonIndex = i;
            buttons[i].onClick.AddListener(() => OnButtonClick(buttonIndex));
        }
    }
    public void OnButtonClick(int buttonIndex)
    {
        //버튼 클릭 시마다 clickCount 증가
        clickCount++;

        //if (clickCount + player.energy > 3)
        //{
        //    for(int i = 0; i < buttons.Length; i++)
        //    {
        //        i = clickCount + player.energy;
        //
        //        buttons[i].interactable = false;
        //    }
        //}

        if (clickCount >= 3)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].interactable = false;
            }
        }
    }
    public void Reset()
    {
        clickCount = -1;
        clickCount++;
        buttons[0].interactable = true;
        buttons[1].interactable = true;
        buttons[2].interactable = true;
        player.actCount.text = $"{player.energy = 3}";
    }
}
