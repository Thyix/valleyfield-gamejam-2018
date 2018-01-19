using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //Déclaration des variables
    public int Etage = 1, EtageText = 1;
    public static GameManager instance = null;
    public AudioClip audioGameOver;

    private Text textEtage;
    private GameObject imageEtage;
    private float delais = 4f;


	// Use this for initialization
	void Start ()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        InitNiveau();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void OnLevelWasLoaded(int level)
    {
        Etage++;
        EtageText++;

        InitNiveau();
    }

    //Initialisation des niveaux / chargement des scènes
    private void InitNiveau()
    {
        //Déclaration des variables
        if ((Etage % 2) == 0)
        {
            imageEtage = GameObject.Find("ImageEtage");
            textEtage = GameObject.Find("TextEtage").GetComponent<Text>();
            SceneManager.LoadScene("Ascenceur");
            textEtage.text = "Étage #" + EtageText;
            imageEtage.SetActive(true);
            Invoke("SortAscenseur", delais);
        }
        else
        {
            string Scene = TitreScene();

            SceneManager.LoadScene(Scene);
        }
    }

    private void SortAscenseur()
    {
        imageEtage.SetActive(false);
    }

    //Pour connaître à quelle scène nous sommes rendu
    private string TitreScene()
    {
        //Déclaration des variables
        string NomScene = "";


        //Traitement
        if (Etage == 1)
        {
            NomScene = "Etage1";
        }
        else
        {
            if (Etage == 3)
            {
                NomScene = "Etage2";
            }
            else
            {
                NomScene = "Etage3";
            }
        }
        return NomScene;
    }


    //Méthode de game over
    public void GameOver()
    {
        //Arrêt de la trame sonore et départ de l'effet game over sonore
        SoundManager.instance.EffetSonore(audioGameOver);

        //Recommence au début du niveau
        Invoke("InitNiveau", 2f);
    }
}
