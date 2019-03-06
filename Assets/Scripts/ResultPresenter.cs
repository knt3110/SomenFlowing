using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UniRx;

public class ResultPresenter : MonoBehaviour 
{

    public Text scorText;
    public Text comboText;
    public Text rankText;

    public AudioSource dramRoll, resultBGM;

    public GameObject baby, boy, man;

    public GameObject fireFlower1, fireFlower2;

    GameModel model;

    float increasingScore, increasingCombo;

    private void Start()
    {
        model = GameModel.Instance;

        increasingScore = 0;
        increasingCombo = 0;

        //rankText.text = "Rank : A";

        Observable.Timer(TimeSpan.FromSeconds(2.5f)).Subscribe(_AppDomain =>
        {
            resultBGM.Play();
            fireFlower1.SetActive(true);
            fireFlower2.SetActive(true);
            if (model.score < model.toBoyScore)
            {
                baby.SetActive(true);
            }
            else if (model.score >= model.toBoyScore && model.score < model.toManScore)
            {
                boy.SetActive(true);
            }
            else
            {
                man.SetActive(true);
            }
        }).AddTo(this);
    }

    private void Update()
    {
        if (increasingScore <= model.score)
        {
            increasingScore += model.score / 120f;
            scorText.text = "スコア : " + increasingScore;
        }
        else
        {
            scorText.text = "スコア : " + model.score;
        }

        if (increasingCombo <= model.maxComboNum)
        {
            increasingCombo += model.maxComboNum / 120f;
            comboText.text = "コンボ : " + increasingCombo;
        }
        else
        {
            comboText.text = "コンボ : " + model.maxComboNum;
        }
    }

    public void onClickReturnButton()
    {
        SceneManager.LoadScene("0_Title");
    }

    private void OnDestroy()
    {
        model.Clear();
    }
}
