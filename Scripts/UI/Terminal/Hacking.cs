using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hacking : MonoBehaviour {

    public Button UIButtonPrefab;
    public Canvas HackingUI;
    public string Suite;

    public string TerminalName = "cmd.exe";
    public GameObject AccessPanel;
    public GameObject HackingPanel;
    public Button BtnExit;
    public Text WordText;
    public Text TryText;
    public Text ConsoleText;
    public Text HeaderText;
    public Text FooterText;
    public List<GameObject> HistoriquePrefab;
    public TextAsset WordList;
    public AudioClip EnterSound;
    public AudioClip SelectSound;
    public AudioClip ErrorSound;

    public Color Highlight = Color.white;
    public int TriesAllowed = 4;
    int ColAmount = 20;

    public string SelectedWord;
    public string ScoreWord = "";

}
