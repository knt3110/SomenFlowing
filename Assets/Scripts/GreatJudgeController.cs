using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatJudgeController : MonoBehaviour 
{
    public GameObject PickedSomenGreat;

    GameView view;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Somen")
        {
            Destroy(collision.gameObject);
            GameObject pickedSomen = Instantiate(PickedSomenGreat, gameObject.transform.position + new Vector3(0.11f, 0f, 0f), gameObject.transform.rotation);
            Destroy(pickedSomen, 1f);

            view = FindObjectOfType<GameView>();
            view.ScoreUPGreat();
        }
    }
}
