using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{

    public Canvas QuitMenu;
    public Button Play;
    public Button Exit;

    private AudioSource Audiosource;

    // Use this for initialization
    void Start()
    {
        QuitMenu = QuitMenu.GetComponent<Canvas>();
        Exit = Exit.GetComponent<Button>();
    }
    public void ExitPress()
    {
        QuitMenu.enabled = true;
        Play.enabled = false;
        Exit.enabled = false;
    }

    public void NoExit()
    {
        QuitMenu.enabled = false;
        Play.enabled = true;
        Exit.enabled = true;
    }

    public void StartLevel()
    {
        Application.LoadLevel("IntroPlay");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
