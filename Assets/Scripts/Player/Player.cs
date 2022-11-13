using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController cc;
    private float speed = 10.0f;
    public float yVelocity = -9.81f;

    private void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(Horizontal, yVelocity, Vertical);
        cc.Move(direction * speed * Time.deltaTime);
    }

}
