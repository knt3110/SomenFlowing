using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExplainPresenter : MonoBehaviour 
{

    public GameObject explainText;

	void Start () {
		
	}
	
	void Update () {
        explainText.transform.position += new Vector3(0f, 0.02f, 0f);
	}

    public void onClickSkipButton()
    {
        SceneManager.LoadScene("2_Game");
    }
}
