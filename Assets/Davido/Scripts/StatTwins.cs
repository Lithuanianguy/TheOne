using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatTwins : MonoBehaviour
{

    public AudioSource dead;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<FirstPersonController>())
            return;
        GetComponent<Animator>().SetBool("Close", true);
        
        
        if(GetComponent<Animator>().GetBool("Done") == false)
        {

            dead.Play();
        }
        

    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.GetComponent<FirstPersonController>())
            return;
        GetComponent<Animator>().SetBool("Close", false);
    }
}
