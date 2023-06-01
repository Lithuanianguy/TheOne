using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public bool canInteract = true;


    protected FirstPersonController player;
    public virtual void OnInteract(FirstPersonController fpController)
    {
        player = fpController;
        Debug.Log("Interact with this");
        



    }
}
