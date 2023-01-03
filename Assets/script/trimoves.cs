using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trimoves : MonoBehaviour
{
    public float speed = 100f;
    public int vidas = 0;
    
    void Start()
    {
        vidas+=1;
    }

    void Update()
    {
        
        if(Input.GetKey(KeyCode.A))
            transform.Rotate(0f, 0f, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0f, 0f, speed * -1 * Time.deltaTime);
        
    }
}
