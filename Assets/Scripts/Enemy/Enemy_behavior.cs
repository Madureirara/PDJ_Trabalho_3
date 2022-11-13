using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_behavior : MonoBehaviour
{
    public itemData data;
    [SerializeField]private int health;
    [SerializeField] private float speed;
    [SerializeField] private GameObject target;
    private Vector3 pos= new Vector3();

    public void Awake()
    {
        health = data.health;
        speed = data.speed;        
        target = GameObject.Find("Player");
        
    }
    public void Follow()
    {
        pos = target.transform.position - transform.position;
        if (pos.magnitude> 1.5f)
        {           
            this.transform.position += pos.normalized * speed * Time.deltaTime;
        }
       
    }
    void Update()
    {
        Follow();
    }
}
