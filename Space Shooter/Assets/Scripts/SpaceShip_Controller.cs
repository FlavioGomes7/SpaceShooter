using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip_Controller : MonoBehaviour
{
    //Status & Componentes
    private Rigidbody2D rb;
    public Space_Ship_SO space_Ship;
    private SpriteRenderer spriteRenderer;
    private int hp;
    private float speed;
    private float attack;

    // Movimento usando as teclas W, A, S e D
    float moveHorizontal;
    float moveVertical;
    Vector2 movement;

    //dire��o do mouse
    Vector3 mousePosition;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = space_Ship.Sprite;
        hp = space_Ship.Hp;
        speed = space_Ship.Speed;
        attack = space_Ship.Attack;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            float moveVertical = Input.GetAxisRaw("Vertical");
            movement = new Vector2(moveHorizontal, moveVertical);
            rb.velocity = movement * speed * Time.deltaTime;
        }
        else
        {
          
        }

        // Olhar na dire��o do mouse
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        transform.up = direction;


    }


}
