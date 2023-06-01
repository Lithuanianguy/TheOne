using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableHeartPieces : InteractableObject

{
    

    public override void OnInteract(FirstPersonController fpController)
    {
        base.OnInteract(fpController);
        player.heartPiece += 1;
        canInteract = false;
        print("test1");
        Destroy(gameObject);


    }



    
}
