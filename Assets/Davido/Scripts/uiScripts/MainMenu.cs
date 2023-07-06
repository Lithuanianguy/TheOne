using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Play()
    {
        SceneManager.LoadScene("Church");
    }

    public void End()
    {
        SceneManager.LoadScene("End");
    }

    public void Main()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void FullScreen()
    {
    
           Screen.fullScreen = !Screen.fullScreen;

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
