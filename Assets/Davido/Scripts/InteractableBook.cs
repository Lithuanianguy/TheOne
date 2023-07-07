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

    public Material cloak;
    public GameObject clo;

    private void Start()
    {
        
    }

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
        book.SetBool("read", true);
        player.canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        spotL.SetBool("Dim", true);
        uiElement.SetActive(false);
        StartCoroutine(FadeIn());
       
    }

    IEnumerator FadeIn()
    {
        for (int i = 0; i < 1; i++)
        {
            yield return new WaitForSeconds(0.001f);
            cloak.SetFloat("_disolve", i + 1);
        }
    }
}
