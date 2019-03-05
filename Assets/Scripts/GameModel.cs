using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : MonoBehaviour 
{

    public readonly static GameModel Instance = new GameModel();

    public int score = 0;
    public int combo = 0;
    public int maxComboNum = 0;

    public int toBoyScore = 300;
    public int toManScore = 600;

    public int perfectScore = 10000;

    public void Clear()
    {
        score = 0;
        combo = 0;
        maxComboNum = 0;
    }
}
