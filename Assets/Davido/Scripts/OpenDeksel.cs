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

    public GameObject angel;

    public GameObject newCam;

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

        player.SetActive(false);
     
        deksel.SetBool("deksel", true);

        angel.SetActive(true);

        newCam.SetActive(true);
        
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
      

    }
}
