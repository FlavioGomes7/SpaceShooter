using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Space_Ship_SO space_Ship;
    private Rigidbody2D rb;
    private float timer;
    private float timerMax = 5f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timerMax)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy_Controller>().TakeDamage(space_Ship.Attack);
            Debug.Log("Acertou");
            Destroy(gameObject);
        }
    }

}
