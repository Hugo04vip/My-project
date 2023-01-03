using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadmoves : MonoBehaviour
{
    public float speed = 100f;
    public float changeTime = 3f;
    int direction = 1;
    Rigidbody2D rigidbody2D;
    float Timer;
    

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Timer = changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        Vector2 position = rigidbody2D.position;
        position.x = position.x + Time.deltaTime * speed * direction;
        rigidbody2D.MovePosition(position);
    }
}
