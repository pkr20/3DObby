using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speedY = 0;
    [SerializeField] float speedX = 0;
    [SerializeField] float speedZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(360 * speedY * Time.deltaTime, 360 * speedX * Time.deltaTime, 360 * speedZ * Time.deltaTime);
    }
}
