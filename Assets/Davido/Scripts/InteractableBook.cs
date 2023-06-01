using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class InteractableBook : InteractableObject
{
    

    public GameObject uiElement;

    public GameObject invisWall;

    public Animator spotL;

    public override void OnInteract(FirstPersonController fpController)
    {
        base.OnInteract(fpController);
        player.canMove = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        invisWall.SetActive(false);
        uiElement.SetActive(true);

    }

    public void ReturnToPlayer()
    {
        player.canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        spotL.SetBool("Dim", true);
        uiElement.SetActive(false);
    }
}
