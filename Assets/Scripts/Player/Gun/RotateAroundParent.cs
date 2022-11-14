using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundParent : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.RotateAround(transform.parent.position, Vector3.up, GameManager.instance.GunRotateSpeed * 100.0f * Time.deltaTime);
    }
}
