using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource music;
    private bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        playMusic();
    }
    private void playMusic() 
    {
        if (Input.GetKey(KeyCode.M) && isOn == true) 
        {
            music.Pause();
            isOn = false;
        } 
        else if (Input.GetKey(KeyCode.M) && isOn == false) 
        {
            music.Play();
            isOn = true;
        }
    }
}
