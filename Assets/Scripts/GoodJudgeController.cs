using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodJudgeController : MonoBehaviour 
{
    public GameObject pickedSomenGood;
    public AudioClip somenPickedSE;

    AudioSource somenPicked;
    GameView view;

    private void Start()
    {
        somenPicked = gameObject.GetComponent<AudioSource>();
        somenPicked.clip = somenPickedSE;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Somen")
        {
            Destroy(collision.gameObject);
            somenPicked.Play();
            GameObject pickedSomen = Instantiate(pickedSomenGood, gameObject.transform.position + new Vector3(0.11f, 0f, 1f), gameObject.transform.rotation);
            Destroy(pickedSomen, 0.3f);
           
            view = FindObjectOfType<GameView>();
            view.ScoreUPGood();
        }
    }
}
