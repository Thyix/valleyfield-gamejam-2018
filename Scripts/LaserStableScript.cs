using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserStableScript : MonoBehaviour
{

    //Déclaration des variables
    public AudioClip audioLaser, audioAlarme;

    private Animator animation;
    private Transform target;
    private GameManager gameManager;

    // Use this for initialization
    void Start()
    {
        animation = GetComponent<Animator>();
        gameManager = GetComponent<GameManager>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Active l'alarme si le joueur touche le laser lorsque celui-ci est actif
        if (target.position == gameObject.transform.position)
        {
            SoundManager.instance.EffetSonore(audioAlarme);

            //Mettre un game over ici
            gameManager.GameOver();
        }
    }
}
