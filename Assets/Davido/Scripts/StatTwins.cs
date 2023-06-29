using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatTwins : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<FirstPersonController>())
            return;
        GetComponent<Animator>().SetBool("Close", true);

    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.GetComponent<FirstPersonController>())
            return;
        GetComponent<Animator>().SetBool("Close", false);
    }
}
