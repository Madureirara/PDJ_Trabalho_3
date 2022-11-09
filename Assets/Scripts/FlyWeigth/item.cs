using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New item", menuName ="Objeto/Detalhe",order =1)]
public class item : ScriptableObject
{
    public int itemIndex;
    public Sprite sprite;
    public float value;
}
