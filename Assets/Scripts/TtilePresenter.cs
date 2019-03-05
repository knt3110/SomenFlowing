using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TtilePresenter : MonoBehaviour 
{
    public AudioSource tapStartButtonSE;

    public void onClickStartButton()
    {
        tapStartButtonSE.Play();
        FadeManager.SetColor(1f, 1f, 1f);
        FadeManager.FadeOut("1_Explain");
    }
}
