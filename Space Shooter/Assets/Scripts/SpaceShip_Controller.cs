using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip_Controller : MonoBehaviour
{
    private RigidyBody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent[RigidyBody2D]();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
