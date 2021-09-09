using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerechaIzquierdaEnemigoController : MonoBehaviour
{
  public float jumpForce = 40;
    private bool  salto=false;
    public float velocityX = 15;
    
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
    rb.velocity = new Vector2(velocityX, 0);
    }
   
    
    }
       
    private void OnCollisionEnter2D(Collision2D collision)
    {
        salto=true; 
         if (salto=true)
        {
            rb.velocity = new Vector2(-velocityX, 0);
        }
        
        
    }

}