using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{

    //Déclaration des variables
    public AudioClip audioLaser, audioAlarme;
    public float chronoActif = 3f, chronoNonActif = 2f;

    private Animator animation;
    private Transform target;
    private bool Actif = true;

    // Use this for initialization
    void Start()
    {
        animation = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Détermine si le laser est actif ou non
        if (Actif)
        {
            chronoActif -= Time.deltaTime;
            if (chronoActif <= 0)
            {
                LaserDesactive();
            }
        }
        else
        {
            chronoNonActif -= Time.deltaTime;

            if (chronoNonActif <= 0)
            {
                LaserActive();
            }
            else
            {
                //Active l'alarme si le joueur touche le laser lorsque celui-ci est actif
                if (target.position == gameObject.transform.position)
                {
                    SoundManager.instance.EffetSonore(audioAlarme);

                    //Mettre un game over ici
                }
            }
        }
    }


    //Désactive le laser pendant 2 secondes
    public void LaserDesactive()
    {
        chronoNonActif = 2f;

        gameObject.SetActive(false);
    }

    //Active le laser pour 3 secondes
    public void LaserActive()
    {
        chronoActif = 3f;

        gameObject.SetActive(true);
    }
}
