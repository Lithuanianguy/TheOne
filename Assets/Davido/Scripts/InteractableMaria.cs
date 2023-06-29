using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class InteractableMaria : InteractableObject
{
    public Animator spotLight;
    public Animator stairWay;

    public Animator holding;

    public Animator[] twins;

    public AudioSource choir;
    public Animator heartComplete;
    public GameObject theHeart;
    public GameObject col;
    
    

    // Start is called before the first frame update
    void Start()
    {
     
    }

    public override void OnInteract(FirstPersonController fpController)
    {
        canInteract = true;

        base.OnInteract(fpController);
        if (player.heartPiece >= 2)
        {
            stairWay.SetBool("CanGo", true);

            canInteract = false;
            theHeart.SetActive(true);

            heartComplete.SetBool("MariaFull", true);
            holding.enabled = true;
            holding.SetTrigger("Hold");

            for (int i = 0; i < twins.Length; i++)
            {
                twins[i].SetBool("Active", false);
            }

            choir.Play();
            spotLight.SetBool("off", true);
            col.SetActive(false);
        }
        else
        {
            stairWay.SetBool("CanGo", false);
            print("nope");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<FirstPersonController>())
            return;
        holding.SetBool("Close", true);

    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.GetComponent<FirstPersonController>())
            return;
        holding.SetBool("Close", false);
    }
}
