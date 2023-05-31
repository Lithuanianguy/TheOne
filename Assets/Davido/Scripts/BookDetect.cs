using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookDetect : MonoBehaviour
{
    public Collider InspectCol;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Book" )
        {
            print("book1");
        }
    }

    private void OnCollisionEnter(Collision InspectCol)
    {
        //if (InspectCol.gameObject.tag )
        //{
        //    print("book2");
        //    Destroy(InspectCol.gameObject);
        //}
    }
}
