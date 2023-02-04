using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class timer : MonoBehaviour
{
    float timeleft = 10.0f;
    public TextMeshProUGUI time;
    public switchScene switchmanager;
    
    void Start()
    {
        //time = gameObject.GetComponent<TextMeshPro>();
    }

    void Update()
    {
        if (timeleft < 0)
        {
            gameover();
        }

        StartCoroutine(updateTime());
    }

    void GameOver()
    {
        SceneManager.LoadScene(sceneName: "menu");
    }

    private IEnumerator updateTime()
    {
        timeleft -= Time.deltaTime;
        
        string minutes = Mathf.Floor(timeleft / 60).ToString("00");
        string seconds = Mathf.Floor(timeleft % 60).ToString("00");

        time.text = (string.Format("{0}:{1}", minutes, seconds));
        yield return new WaitForSeconds(1.0f);
    }
    void gameover()
    {
        SceneManager.LoadScene(sceneName: "end");
    }
}
