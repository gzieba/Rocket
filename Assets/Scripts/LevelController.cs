using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ReloadCurrentLevel()
    {
        SceneManager.LoadScene("Level_" + (SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void NextLevel()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene("Level_" + ++currentIndex);
    }
}
