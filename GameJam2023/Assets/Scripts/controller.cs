using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private Ray ray; // The ray   
    private RaycastHit hit; // What we $$anonymous$$t
    public points pmanager;
    public spawner smanager;
    public AudioSource wilhelmSound;
    public AudioSource scream1Sound;
    public AudioSource scream2Sound;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Ray will be sent out from where your mouse is located    
        if (Physics.Raycast(ray, out hit, 1000.0f) && Input.GetMouseButtonDown(0)) // On left click we send down a ray
        {
            pmanager.addpoints(+100);
            smanager.removeCivilian();
            Destroy(hit.collider.gameObject); // Destroy what we hit
            soundPlay();
        }
    }

    private void soundPlay() 
    {
        System.Random r = new System.Random();
        int rSound = r.Next(3);
        if (rSound == 0) 
        {
            wilhelmSound.Play();
        }
        else if (rSound == 1)
        {
            scream1Sound.Play();
        }
        else if (rSound == 2)
        {
            scream2Sound.Play();
        }
    }
}

