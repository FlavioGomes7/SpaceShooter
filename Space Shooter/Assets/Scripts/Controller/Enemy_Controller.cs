using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    //Status & Componentes
    private int hp;
    private int attack;
    private float speed;
    [SerializeField] private Enemy_SO enemy_info;
    [SerializeField] private Rigidbody2D rb;

    //Alvo
    [SerializeField]private GameObject player;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        hp = enemy_info.Hp;
        speed = enemy_info.Speed;
        attack = enemy_info.Attack;
        direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            Die();
        }

    }
    public int DealDamage()
    {
        return attack;
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
