using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanishZoneController : MonoBehaviour 
{
    GameView view;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Somen")
        {
            Destroy(collision.gameObject);
            view = FindObjectOfType<GameView>();
            view.ResetCombo();
        }
    }
}
