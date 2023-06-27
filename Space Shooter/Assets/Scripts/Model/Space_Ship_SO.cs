using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Space_Ship_Info", menuName = "ScriptableObjects/Space_Ship")]
public class Space_Ship_SO : ScriptableObject
{
    [SerializeField] private Sprite sprite;
    [SerializeField] private int hp;
    [SerializeField] private float speed;
    [SerializeField] private float attack;

    public Sprite Sprite => sprite;
    public int Hp => hp;
    public float Speed => speed;
    public float Attack => attack;
}
