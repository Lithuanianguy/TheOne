using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractableMaria : InteractableObject
{
   
    public Animator stairWay;
    public Animator heartComplete;
    public GameObject theHeart;

    

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
}
