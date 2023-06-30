using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class InteractableJesusObj : InteractableObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void OnInteract(FirstPersonController fpController)
    {
        canInteract = true;

        base.OnInteract(fpController);
       
        player.jesusObject += 1;
        canInteract = false;
        print("testJesus");
        Destroy(gameObject);
      

    }
}
