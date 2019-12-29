using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuStartButton : Button
{
    // Start is called before the first frame update
    void Start()
    {
        onClick.AddListener(LoadFirstLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
    }
}
