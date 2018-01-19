using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pause : MonoBehaviour {

    public GameObject PauseMenu;
    public Text PauseName;
    public Button Resume;
    public Button BackToMenu;

    public void Start()
    {
        PauseMenu = GameObject.Find("Pause");
        PauseName = GetComponent<Text>();
        Resume = GetComponent<Button>();
        BackToMenu = GetComponent<Button>();
        PauseMenu.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        PauseMenu = GameObject.Find("Pause");
        PauseMenu.SetActive(false);
    }

    public void BackMenu()
    {
        Application.LoadLevel("MainMenu");
    }
}
