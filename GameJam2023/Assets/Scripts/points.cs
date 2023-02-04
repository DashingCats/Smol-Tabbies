using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class points : MonoBehaviour
{
    public int pointTotal = 0;
    private TextMeshProUGUI pointText;
    //private TextMeshProUGUI pointTextend;

    // Start is called before the first frame update
    void Start()
    {
        
            
    }

    // Update is called once per frame
    void Update()
    {
        pointText = GameObject.FindGameObjectWithTag("point").GetComponent<TextMeshProUGUI>();
        if (pointText != null)
        {
            pointText.text = "" + pointTotal;
        }
        else
            return;

            
    }

    public void addpoints(int add)
    {
        pointTotal += add;
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
