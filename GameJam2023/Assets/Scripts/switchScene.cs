using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {/*
        Button btn = button.GetComponent<Button>();
        if (btn != null)
        {

            btn.onClick.AddListener(changeScene);
        }
        else
            return;*/
    }

    public void changeScene()
    {
        SceneManager.LoadScene(sceneName: "main");
    }

}
