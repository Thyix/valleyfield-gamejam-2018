using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyHelper : MonoBehaviour {

    public Canvas Helper;
    public Text HelperText;
    public AudioClip SoundEffect;
    public string NewText;
    public GameObject Trigger;

    private void Start()
    {
        Helper = GetComponent<Canvas>();
        HelperText = GetComponent<Text>();
        SoundEffect = GetComponent<AudioClip>();
        Trigger = GameObject.Find("CollisionZone");
    }
    private void Awake()
    {
        HelperText.text = NewText;
    }
}
