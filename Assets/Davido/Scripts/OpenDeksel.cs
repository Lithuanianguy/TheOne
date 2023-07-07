using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDeksel : MonoBehaviour
{

    public GameObject eyeclose;

    public GameObject player;

    public InteractableHands[] hands;

    public Animator deksel;
    public Animator angle;

    public GameObject angel;

    public GameObject newCam;

    public float engelDelay;
    public float uiDelay;

    public AudioSource angelS;
 
    public AudioSource old;
    public AudioSource noise;

    public void CheckHands()
    {
        for (int i = 0; i < hands.Length; i++)
        {

            if (!hands[i].correctPositon)
                return;

        }

        for (int i = 0; i < hands.Length; i++)
        {

            hands[i].canInteract = false;
                
            
        }

        //anim go brr
        
        eyeclose.SetActive(true);
        Invoke("Eee", uiDelay);
        
        deksel.SetBool("deksel", true);
        Invoke("EngelAan", engelDelay) ;

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    void EngelAan()
    {
        angle.SetBool("go", true);
        Invoke("Eee", uiDelay);

       
        angelS.Play();
     
        old.volume = 0.2f;
        noise.Stop();
        angel.SetActive(true);
    }

    void Eee()
    {
        angel.SetActive(true);
        newCam.SetActive(true);
        player.SetActive(false);
    }
}
