using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy_Info", menuName = "ScriptableObjects/Enemy")]
public class Enemy_SO : ScriptableObject
{
    //Atributos
    [SerializeField] private int hp;
    [SerializeField] private int attack;
    [SerializeField] private float speed;
    [SerializeField] private int value;

    //Getters
    public int Hp => hp;
    public int Attack => attack;
    public float Speed => speed;
    public int Value => value;
    
}
