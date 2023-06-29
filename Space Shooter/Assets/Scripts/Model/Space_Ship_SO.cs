using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Space_Ship_Info", menuName = "ScriptableObjects/Space_Ship")]
public class Space_Ship_SO : ScriptableObject
{
    [SerializeField] private int hp;
    [SerializeField] private float speed;
    [SerializeField] private int attack;

    public int Hp => hp;
    public float Speed => speed;
    public int Attack => attack;
}
