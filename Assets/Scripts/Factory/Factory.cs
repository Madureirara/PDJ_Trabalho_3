using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
   public static GameObject CreateObject(/*Mesh mesh, Material material, Vector3 pos*/)
    {
        GameObject obj = new GameObject();
        //obj.AddComponent<>();
        return obj;
        
    }
}
