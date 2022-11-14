using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
   public static GameObject CreateObject(Mesh mesh, Material[] materials, Vector3 pos, ItemData data)
    {
        GameObject obj = new GameObject();
        obj.name = "Enemy";
        obj.AddComponent<MeshRenderer>().materials = materials;
        obj.AddComponent<MeshFilter>().mesh = mesh;
        obj.AddComponent<CapsuleCollider>().center = new Vector3(0.0f, 1.0f, 0.0f);
        obj.GetComponent<CapsuleCollider>().radius = 0.5f;
        obj.GetComponent<CapsuleCollider>().height = 1.8f;
        obj.AddComponent<Enemy_behavior>().data = data;
        obj.GetComponent<Enemy_behavior>().Speed = data.speed;
        obj.GetComponent<Enemy_behavior>().Health = data.health;
        obj.AddComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        obj.transform.position = pos;
        return obj;
        
    }
}
