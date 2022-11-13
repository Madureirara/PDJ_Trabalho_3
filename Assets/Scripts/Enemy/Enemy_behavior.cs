using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_behavior : MonoBehaviour
{
    public itemData data;
    [SerializeField]private int health;
    [SerializeField] private float speed;
    [SerializeField] private GameObject target;
    private Vector3 pos;

    public void Awake()
    {
        health = data.health;
        speed = data.speed;
        target = data.target;       
    }
    public void Follow()
    {
        
    }
}
