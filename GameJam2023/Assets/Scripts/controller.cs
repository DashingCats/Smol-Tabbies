using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private Ray ray; // The ray   
    private RaycastHit hit; // What we $$anonymous$$t
    public points pmanager;
    public spawner smanager;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Ray will be sent out from where your mouse is located    
        if (Physics.Raycast(ray, out hit, 1000.0f) && Input.GetMouseButtonDown(0)) // On left click we send down a ray
        {
            pmanager.addpoints(+100);
            smanager.removeCivilian();
            Destroy(hit.collider.gameObject); // Destroy what we hit
        }
    }

}

