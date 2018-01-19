using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColHelper : MonoBehaviour {

    public GameObject Hint;
    public string HintName;
    public AudioClip Notif;
    bool InZone = false;
    private void Start()
    {
        Hint = GameObject.Find(HintName);
        Hint.SetActive(false);
        InZone = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.ToString() == "Player (UnityEngine.GameObject)")
        {
            
            Hint.SetActive(true);
            InZone = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.ToString() == "Player (UnityEngine.GameObject)")
        {
            Hint.SetActive(true);
            InZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Hint.SetActive(false);
        InZone = false;
    }
}
