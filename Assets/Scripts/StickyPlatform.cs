using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);// refers to transform component of whichever object the script is applied to
        }//make the player^ a child of this platform
        //set parent transform
        //set player transform
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);// refers to transform component of whichever object the script is applied to
        }
    }


}

