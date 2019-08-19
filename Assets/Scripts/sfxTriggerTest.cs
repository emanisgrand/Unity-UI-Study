using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class sfxTriggerTest : MonoBehaviour
{
    private Button buttons;
    private EventSystem eventSystem;
    private Button currentButton;
    public AudioClip highlightSound;
    private AudioSource source {get {return GetComponent<AudioSource>(); }}

    private void Awake() {
        gameObject.AddComponent<AudioSource>();
        eventSystem = FindObjectOfType<EventSystem>();
    }
    
    void Start()
    {
        source.clip = highlightSound;
        source.playOnAwake = false;
    }
}
