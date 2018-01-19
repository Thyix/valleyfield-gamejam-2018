using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {
    //public Text Timer;
    private float time = 0f;
    public int Etage = 0;

    private void Start()
    {
        GameObject Use = GameObject.Find("Player 1");
    }

    private void Update()
    {
        //Timer = GameObject.Find("Timer").GetComponent<Text>();
        //time += Time.deltaTime;
        //Timer.text = time.ToString("f0");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject UsePrefab = GameObject.Find("BtnUse");
        Instantiate(UsePrefab, transform.position, transform.rotation);
    }
}
