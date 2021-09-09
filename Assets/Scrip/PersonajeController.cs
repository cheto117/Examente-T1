using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocityX = 15;
    public float jumpForce = 40;

    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private Animator animator;

    private const int ANIMATION_RUN = 0;
    private const int ANIMATION_JUMP= 1;
    private const int ANIMATION_DEAD= 2;
   
    private const string  a= "Estado";
    private bool  salto=false;

    
    void Start()
    {
        Debug.Log("Iniciando Game Object");
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        rb.velocity = new Vector2(velocityX, rb.velocity.y); 
        changeAnimation(a,ANIMATION_RUN);
    

        
         if (Input.GetKeyUp(KeyCode.Space)&& salto)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // salta
            changeAnimation(a,ANIMATION_JUMP); // saltar
            salto=false;
        } 
      
    }  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        salto=true; 
        
    }

    private void changeAnimation(string a, int animation)
    {
        animator.SetInteger(a, animation);
    }
}
