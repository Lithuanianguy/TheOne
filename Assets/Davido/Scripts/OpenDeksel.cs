using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDeksel : MonoBehaviour
{

    public InteractableHands[] hands;

    public Animator deksel;

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
        deksel.SetBool("deksel", true);
    }
}
