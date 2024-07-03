using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void quitGame()
    {
        Application.Quit();
    }
    public void switchSceneGame()
    {
        SceneManager.LoadScene(2);
    }
    public void switchGameWin() {
        SceneManager.LoadScene(3);
    }
    public void switchGameover()
    {
        SceneManager.LoadScene(4);
    }
    public void switchRule()
    {
        SceneManager.LoadScene(1);
    }

}
