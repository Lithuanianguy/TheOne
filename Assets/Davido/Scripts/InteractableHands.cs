using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InteractableHands : InteractableObject
{

    public bool correctPositon;

    public int newRotation;

    public OpenDeksel deksel;

    public AudioSource turnl;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    public override void OnInteract(FirstPersonController fpController)
    {
       
       
        Debug.Log(newRotation);
        Debug.Log(Mathf.RoundToInt(transform.eulerAngles.y));
        int targetRotate = Mathf.RoundToInt(transform.eulerAngles.y) + 45;
        turnl.Play();
        if (targetRotate >= 360)
            targetRotate -= 360;
        Debug.Log(targetRotate);
        

        canInteract = false;
        StartCoroutine(Rotate());
        
       
    }

    private IEnumerator Rotate()
    {
        for (int i = 0; i < 10; i++)
        {
            transform.Rotate(0, 4.5f, 0);
            yield return new WaitForSeconds(0.05f); 

        }
        if (newRotation == Mathf.RoundToInt(transform.eulerAngles.y))
        {
            Debug.Log("yer");
            correctPositon = true;
            deksel.CheckHands();
        }
        else
        {
            correctPositon = false;
        }


        canInteract = true;

    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
