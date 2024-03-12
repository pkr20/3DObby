using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBody"))
        {
            Wompwomp();
        }
        
    }
    void Wompwomp()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false; //if enabled, doesnt collision anymore ( kinematic )
        ReloadLevel();

     }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // reloads current scene
        

    }
    void Update()
    {
        if(gameObject.transform.position.y < -13.2445707) {
            Wompwomp();
        }
    }// if player falls
}

