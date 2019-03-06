using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameModel : MonoBehaviour
{

    public readonly static GameModel Instance = new GameModel();

    public int score = 0;
    public int combo = 0;
    public int maxComboNum = 0;

    public int perfectScore = 200 * 110;
    public int toBoyScore = 200 * 30;
    public int toManScore = 200 * 90;

    public List<string[]> somenList = new List<string[]>();

    public void ReadCSVFile()
    {
        string filename = "test3";
        var CSVFile = Resources.Load("CSV/" + filename) as TextAsset;
        var reader = new StringReader(CSVFile.text);

        while(reader.Peek() > -1)
        {
            var lineData = reader.ReadLine();
            var lineArray = lineData.Split(',');
            somenList.Add(lineArray);
        }

        Debug.Log(somenList[0][1]);
    }

    public void Clear()
    {
        score = 0;
        combo = 0;
        maxComboNum = 0;
        somenList = new List<string[]>();
    }
}
