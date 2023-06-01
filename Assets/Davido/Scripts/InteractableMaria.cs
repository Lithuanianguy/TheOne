using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class InteractableMaria : InteractableObject
{
   
    public Animator stairWay;
    

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
