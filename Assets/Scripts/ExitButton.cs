using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitButton : Button
{
    private LevelController levelController;
    // Start is called before the first frame update
    void Start()
    {
        levelController = new LevelController();
        onClick.AddListener(LoadMainMenu);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
