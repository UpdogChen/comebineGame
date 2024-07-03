using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bottomControl : MonoBehaviour
{
    [SerializeField] GameObject winBottom;
    [SerializeField] GameObject gameoverBottom;


    private void Update()
    {
        detectWin();
        detectGameover();
        
    }

    void detectWin()
    {
        GameObject countW = GameObject.FindGameObjectWithTag("fat");

        if (countW)
        {
            Time.timeScale = 0f;
            winBottom.SetActive(true);
        }
    }
    void detectGameover()
    {
        GameObject countL = GameObject.FindGameObjectWithTag("gameover");
        if (countL)
        {
            Time.timeScale = 0f;
            gameoverBottom.SetActive(true);
        }
    }
    
}
