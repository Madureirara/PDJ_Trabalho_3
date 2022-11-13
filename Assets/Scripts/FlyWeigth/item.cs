using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public itemData data;
    public int health;
    void Start()
    {
        data.CathItem(gameObject);
        health = data.health;
    }
}
