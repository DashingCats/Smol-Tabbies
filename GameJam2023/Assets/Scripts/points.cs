using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class points : MonoBehaviour
{
    public int pointTotal = 0;
    public TextMeshProUGUI pointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "" + pointTotal;
    }

    public void addpoints(int add)
    {
        pointTotal += add;
    }
}
