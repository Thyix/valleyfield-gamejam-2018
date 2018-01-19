using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    //Déclaration des variables publiques de sons
    public AudioSource musicSource;
    public AudioSource effetsSource;
    public static SoundManager instance = null;


	// Initialisation
	void Start ()
    {
        //Pour s'assurer que une instance de SoundManager n'existe pas
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        //Pour que la musique ne s'arrête pas entre le changement de niveau, même chanson.
        DontDestroyOnLoad(gameObject);
	}


    //Méthode pour générer les effets sonores du jeu
    public void EffetSonore(AudioClip sons)
    {
        //Déclaration des variables
        effetsSource.clip = sons;

        //Joue le son
        effetsSource.Play();
    }

}
