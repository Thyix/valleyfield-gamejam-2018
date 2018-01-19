using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionZone : MonoBehaviour {

    GameObject BtnUsePref;
    GameObject terminal;
    bool InZone = false;
    private void Start()
    {
        BtnUsePref =GameObject.Find("BtnUse");
        terminal = GameObject.Find("DisIsDaWae");
        BtnUsePref.SetActive(false);
        terminal.SetActive(false);
        InZone = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.ToString() == "Player (UnityEngine.GameObject)")
        {
            BtnUsePref.SetActive(true);
            InZone = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.ToString() == "Player (UnityEngine.GameObject)")
        {
            BtnUsePref.SetActive(true);
            InZone = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.ToString() == "Player (UnityEngine.GameObject)")
        {
            BtnUsePref.SetActive(false);
            InZone = false;
        }
    }
    private void Update()
    {
        KeyCode Use = KeyCode.E;

        if (Input.GetKeyDown(Use) && InZone)
        {
            terminal.SetActive(true);
        }
    }

}
