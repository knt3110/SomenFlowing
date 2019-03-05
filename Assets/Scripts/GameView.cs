using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour 
{
    public Text Score;
    public Text Combo;

    GameModel model;

	void Start () {
        model = GameModel.Instance;
	}
	
	void Update () {
		
	}

    public void ScoreUPGood()
    {
        model.score += 100;
        model.combo += 1;
        Score.text = "Score : " + model.score;
        Combo.text = "Combo : " + model.combo;
    }

    public void ScoreUPGreat()
    {
        model.score += 100;
        Score.text = "Score : " + model.score;
    }

    public void ResetCombo()
    {
        if (model.combo > model.maxComboNum)
        {
            model.maxComboNum = model.combo;
        }
        model.combo = 0;
        Combo.text = "Combo : " + model.combo;
    }
}
