using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void nextLevel()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void restartLevel()
    {
        SceneManager.LoadScene("Level 1");
    }
}
