using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topHareketi : MonoBehaviour
{
    Rigidbody2D rgb;
    //speed for ball
    public float hiz;
    float posX, posY;

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        posX = Input.acceleration.x * hiz;
        posY = Input.acceleration.y * hiz;

    }
    void FixedUpdate(){
        rgb.velocity= new Vector2(rgb.velocity.x + posX, rgb.velocity.y + posY);
    }
}
