﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UniRx;

public class GamePresenter : MonoBehaviour 
{
    public GameObject somen1, somen2, somen3, somen4;
    public GameObject start1, start2, start3, start4;
    public GameObject goodJudge;
    public GameObject greatJudge;
    public AudioSource BGM;
    public GameObject baby, boy, man;
    public GameObject charaChangeParticle;

    GameModel model;

    bool toBoyFlag = true;
    bool toManFlag = true;

	void Start () {
        model = GameModel.Instance;
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(somen1, start1.transform.position, start1.transform.rotation);
            Instantiate(somen2, start2.transform.position, start2.transform.rotation);
            Instantiate(somen3, start3.transform.position, start3.transform.rotation);
            Instantiate(somen4, start4.transform.position, start4.transform.rotation);
        }

        if (model.score < model.toBoyScore)
        {
            baby.SetActive(true);                  
        }
        else if (model.score >= model.toBoyScore && model.score < model.toManScore)
        {
            if (toBoyFlag)
            {
                toBoyFlag = false;
                charaChangeParticle.SetActive(true);
                Observable.Timer(TimeSpan.FromSeconds(1.5f)).Subscribe(_ =>
                {
                    boy.SetActive(true);
                    baby.SetActive(false);
                }).AddTo(this);
            }
        }
        else if (model.score >= model.toManScore)
        {
            if (toManFlag)
            {
                toManFlag = false;
                charaChangeParticle.SetActive(false);
                charaChangeParticle.SetActive(true);
                Observable.Timer(TimeSpan.FromSeconds(1.5f)).Subscribe(_ =>
                {
                    boy.SetActive(false);
                    man.SetActive(true);
                }).AddTo(this);
            }
        }

        if (!BGM.isPlaying)
        {
            Observable.Timer(TimeSpan.FromSeconds(2f)).Subscribe(_AppDomain =>
            {
                SceneManager.LoadScene("3_Result");
            }).AddTo(this);
        }
    }

    public void TapButton1()
    {
        GameObject goodJudgeObject = Instantiate(goodJudge, new Vector3(-5.07f, -3.73f, -1f), Quaternion.identity);
        GameObject greatJudgeObject = Instantiate(greatJudge, new Vector3(-5.07f, -3.73f, -1f), Quaternion.identity);
        Destroy(goodJudgeObject, 0.1f);
        Destroy(greatJudgeObject, 0.1f);
    }

    public void TapButton2()
    {
        GameObject goodJudgeObject = Instantiate(goodJudge, new Vector3(-1.72f, -3.73f, -1f), Quaternion.identity);
        GameObject greatJudgeObject = Instantiate(greatJudge, new Vector3(-1.72f, -3.73f, -1f), Quaternion.identity);
        Destroy(goodJudgeObject, 0.1f);
        Destroy(greatJudgeObject, 0.1f);
    }

    public void TapButton3()
    {
        GameObject goodJudgeObject = Instantiate(goodJudge, new Vector3(1.72f, -3.73f, -1f), Quaternion.identity);
        GameObject greatJudgeObject = Instantiate(greatJudge, new Vector3(1.72f, -3.73f, -1f), Quaternion.identity);
        Destroy(goodJudgeObject, 0.1f);
        Destroy(greatJudgeObject, 0.1f);
    }

    public void TapButton4()
    {
        GameObject goodJudgeObject = Instantiate(goodJudge, new Vector3(5.07f, -3.73f, -1f), Quaternion.identity);
        GameObject greatJudgeObject = Instantiate(greatJudge, new Vector3(5.07f, -3.73f, -1f), Quaternion.identity);
        Destroy(goodJudgeObject, 0.1f);
        Destroy(greatJudgeObject, 0.1f);
    }
}