using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip_Controller : MonoBehaviour
{
    //Status & Componentes
    private Rigidbody2D rb;
    [SerializeField] private Space_Ship_SO space_Ship;
    private int hp;
    private float speed;
    private float attack;

    // Movimento usando as teclas W, A, S e D
    float moveHorizontal;
    float moveVertical;
    Vector2 movement;

    //direcao do mouse
    Vector3 mousePosition;
    Vector2 direction;

    //Atirar
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;


    // Start is called before the first frame update
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
        hp = space_Ship.Hp;
        speed = space_Ship.Speed;
        attack = space_Ship.Attack;

    }

    // Update is called once per frame
    void Update()
    {
        //GameOver
        if(hp <= 0)
        {

            GameManager.instance.NewHighScore();
            GameManager.instance.ResetPoints();
            GameManager.instance.BackToMenu();
            GameManager.instance.ClearEnemies("Enemy");
            Destroy(gameObject);       
        }
        else
        {
            GameManager.instance.ShowLife(hp);
        }

        //Movimentação
        if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            moveHorizontal = Input.GetAxisRaw("Horizontal");
            moveVertical = Input.GetAxisRaw("Vertical");
            movement = new Vector2(moveHorizontal, moveVertical);
            rb.velocity = movement.normalized * speed;
        }

        //Pause
        if(Input.GetButton("Cancel"))
        {
            GameManager.instance.Pause();
        }

        //Atirar
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
        }

        // Olhar na direcao do mouse
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        transform.up = direction;


    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            hp -= other.GetComponent<Enemy_Controller>().DealDamage();
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }




}
