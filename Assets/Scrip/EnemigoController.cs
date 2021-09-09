using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoController : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpForce = 40;
    private bool  salto=false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        if(jumpForce==jumpForce && salto){

       rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // salta
       salto=false;
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        salto=true; 
    }
}
