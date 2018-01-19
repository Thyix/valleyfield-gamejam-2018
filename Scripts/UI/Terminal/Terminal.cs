using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terminal : MonoBehaviour {

    public KeyCode Enter = KeyCode.KeypadEnter;
    public KeyCode Quit = KeyCode.Tab;

    public Button Erase;
    public Button btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
    public Text Show;
    public Text Explanation;
    public Image panel;
    public string NextLevel;
    public GameObject Wrong;
    public GameObject Attente;
    public AudioClip ErrorHack;
    public AudioClip OpenHackCommand;
    public AudioClip audioAscenceur;
    int i = 0;

    public string SecretKey;
    GameObject Canvas;

    public void Start()
    {
        Canvas = GameObject.Find("DisIsDaWae");
        panel = GetComponent<Image>();
        Show.GetComponent<Text>();
        Explanation = GetComponent<Text>();
        btn0 = GetComponent<Button>();
        btn1 = GetComponent<Button>();
        btn2 = GetComponent<Button>(); 
        btn3 = GetComponent<Button>();
        btn4 = GetComponent<Button>();
        btn5=  GetComponent<Button>();
        btn6 = GetComponent<Button>();
        btn7 = GetComponent<Button>();
        btn8=  GetComponent<Button>();
        btn9 = GetComponent<Button>();
        Erase = GetComponent<Button>();
        Wrong.GetComponent<Text>();
        Wrong.SetActive(false);

        Attente = GameObject.Find("Ascenseur");
        SoundManager.instance.musicSource.Stop();
        Attente.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Canvas = GameObject.Find("DisIsDaWae");
            Canvas.SetActive(false);
            SoundManager.instance.EffetSonore(OpenHackCommand);
        }
        if (Show.text.Length > 3)
        {
            if (Show.text == SecretKey)
            {
                RestartKeyCode();
            }
            else
            {
                Show.text = "";
                SoundManager.instance.EffetSonore(ErrorHack);
                Wrong.SetActive(true);
            }
        }
    }

    public void Click0()
    {
        Show.text += "0";
    }
    public void Click1()
    {
        Show.text += "1";
    }
    public void Click2()
    {
        Show.text += "2";
    }
    public void Click3()
    {
        Show.text += "3";
    }
    public void Click4()
    {
        Show.text += "4";
    }
    public void Click5()
    {
        Show.text += "5";
    }
    public void Click6()
    {
        Show.text += "6";
    }
    public void Click7()
    {
        Show.text += "7";
    }
    public void Click8()
    {
        Show.text += "8";
    }
    public void Click9()
    {
        Show.text += "9";
    }
    public void ClickErase()
    {
        Show.text = "";
    }

    private void RestartKeyCode()
    {

        Attente.SetActive(true);
        Invoke("NewLevel", 3);
        //StartCoroutine(waiter());
        //Application.LoadLevel(NextLevel);
        SoundManager.instance.EffetSonore(audioAscenceur);
        Destroy(Canvas);
    }
    void NewLevel()
    {
        Application.LoadLevel(NextLevel);
    }


    //IEnumerator waiter()
    //{
    //    float waitTime = 50;
    //    yield return wait(waitTime);
    //}


    //IEnumerator wait(float waitTime)
    //{
    //    float counter = 0;

    //    while (counter < waitTime)
    //    {
    //        //Increment Timer until counter >= waitTime
    //        counter += Time.deltaTime;
    //    }
    //    Debug.Log("We have waited for: " + counter + " seconds");
    //    //Wait for a frame so that Unity doesn't freeze
    //    yield return null;
    //}

}

