using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public itemData data;
    public int health;
    public CharacterController cc;
    public float speed;
    public float yVelocity = -9.81f;

    void Awake()
    {
        health = data.health;
        speed = data.speed;
    }
    private void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(Horizontal, yVelocity, Vertical);
        cc.Move(direction * speed * Time.deltaTime);
        LookAtMouse();
    }
    void LookAtMouse() 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            this.transform.rotation = Quaternion.LookRotation(hit.point);
        }
    }
}
