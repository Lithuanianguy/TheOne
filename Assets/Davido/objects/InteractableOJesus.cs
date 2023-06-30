using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class InteractableOJesus : InteractableObject
{

    public GameObject theObjects;
    public Animator doorangel;
    public GameObject theLights;

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
        if (player.jesusObject >= 3)
        {
            print("hey");
            theObjects.SetActive(true);

            theLights.SetActive(false);
            
            canInteract=false;

        }
       


    }




}
