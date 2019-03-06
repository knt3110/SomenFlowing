using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class RecordPresenter : MonoBehaviour 
{

    public Image button1, button2, button3, button4;

    float currentTime = 0;
    public float adjustTime = 4.5f;

    public string fileName = "test";
    StreamWriter sw;
    FileInfo fi;

	void Start () {
        fi = new FileInfo(Application.dataPath + "/Resources/CSV/" + fileName + ".csv");
    }
	
	void Update () {

        currentTime += Time.deltaTime;
		
        if(Input.GetKeyDown(KeyCode.D))
        {
            button1.color = Color.yellow;
            WriteData(currentTime - adjustTime, 1);
            Observable.Timer(TimeSpan.FromSeconds(0.3f)).Subscribe(_ =>
            {
                button1.color = Color.white;
            }).AddTo(this);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            button2.color = Color.yellow;
            WriteData(currentTime - adjustTime, 2);
            Observable.Timer(TimeSpan.FromSeconds(0.3f)).Subscribe(_ =>
            {
                button2.color = Color.white;
            }).AddTo(this);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            button3.color = Color.yellow;
            WriteData(currentTime - adjustTime, 3);
            Observable.Timer(TimeSpan.FromSeconds(0.3f)).Subscribe(_ =>
            {
                button3.color = Color.white;
            }).AddTo(this);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            button4.color = Color.yellow;
            WriteData(currentTime - adjustTime, 4);
            Observable.Timer(TimeSpan.FromSeconds(0.3f)).Subscribe(_ =>
            {
                button4.color = Color.white;
            }).AddTo(this);
        }
    }

    void WriteData(float time, int number)
    {
        sw = fi.AppendText();
        sw.WriteLine(time + "," + number);
        sw.Flush();
        sw.Close();
    }
}
