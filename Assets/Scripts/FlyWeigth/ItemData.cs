using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New item", menuName ="Objeto/Detalhe",order =1)]
public class ItemData : ScriptableObject
{   
    public int health= 50;
    public float speed= 10;    
    public void CathItem(GameObject obj)
    {
        Debug.Log(obj.name);
    }
}
