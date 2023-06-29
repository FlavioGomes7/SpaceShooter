using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following_Camera : MonoBehaviour
{
    private Vector3 offSet = new Vector3(0f, 0, -10f);
    private float smoothTime = 0.5f;
    private Vector3 velocity = Vector3.zero;
    Vector3 targetPosition;
    [SerializeField] private Transform target;

    void FixedUpdate()
    {
      if(target == null)
      {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
      }
      targetPosition = target.position + offSet;
      transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    
    }
}
