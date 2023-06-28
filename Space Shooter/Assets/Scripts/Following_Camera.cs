using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following_Camera : MonoBehaviour
{
    GameObject tf;
    GameObject player;
    Vector2 pos;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        tf = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
      pos.Set(tf.transform.position.x, tf.transform.position.y);
    }
}
