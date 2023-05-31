using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public virtual void OnInteract(FirstPersonController fpController)
    {
        Debug.Log("Interact with this");
    }
}
