using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pausel;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameIsPaused = false;
    }


    public void Pause()
    {
        pausel.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        GameIsPaused = true;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
               Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}
