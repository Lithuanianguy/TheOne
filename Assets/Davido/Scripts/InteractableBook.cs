using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;

public class InteractableBook : InteractableObject
{
    

    public GameObject uiElement;

    public GameObject invisWall;

    public Animator spotL;
    public Animator book;

    public override void OnInteract(FirstPersonController fpController)
    {
        base.OnInteract(fpController);
        player.canMove = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        invisWall.SetActive(false);
        uiElement.SetActive(true);
        book.SetBool("read", false);

    }

    public void ReturnToPlayer()
    {
        player.canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        spotL.SetBool("Dim", true);
        uiElement.SetActive(false);
        book.SetBool("read", true);
    }
}
