using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_behavior : MonoBehaviour
{
    public ItemData data;
    [SerializeField] private int health;
    public int Health{get {return health;} set {health = value;}}
    [SerializeField] private float speed;
    public float Speed{get {return speed;} set {speed = value;}}
    [SerializeField] private GameObject target;
    private Vector3 pos= new Vector3();

    public void Awake()
    {        
        // health = data.health;
        // speed = data.speed;        
        target = GameObject.Find("Player");
        
    }
    private void Start() {
        InvokeRepeating("DoDamage", 0.0f, 1.0f);
    }
    public void Follow()
    {
        pos = target.transform.position - transform.position;
        pos.y = 0;
        this.transform.rotation = Quaternion.LookRotation(pos);
        if (!NearTarget())
        {
            this.transform.position += pos.normalized * speed * Time.deltaTime;
        }
       
    }
    private bool NearTarget(){
        bool isNear = false;
        if (Vector3.Distance(transform.position, target.transform.position) < 1.5f)
        {
            isNear = true;
        }
        return isNear;
    }
    void FixedUpdate()
    {
        Follow();
    }
    private void DoDamage()
    {
        if (NearTarget())
        {
            GameManager.instance.RemoveHealth();
        }
    }
    public void TakeDamage(){
        Health--;
        if (Health < 1)
        {
            GameManager.instance.AddPoints(1);
            Destroy(this.gameObject);
        }
    }
}
