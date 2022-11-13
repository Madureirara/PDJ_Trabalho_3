using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New item", menuName ="Objeto/Detalhe",order =1)]
public class itemData : ScriptableObject
{   
    public int health= 50;
    public float speed;
    public GameObject target;  
    
    public void CathItem(GameObject obj)
    {
        Debug.Log(obj.name);
    }
}
