using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(changeScene);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void changeScene()
    {
        SceneManager.LoadScene(sceneName: "main");
    }

}
