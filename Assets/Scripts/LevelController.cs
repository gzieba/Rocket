using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private int currentIndex = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level_0" + ++currentIndex);
    }
}
