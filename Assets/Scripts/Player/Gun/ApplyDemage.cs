using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyDemage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Enemy")
        {
            other.gameObject.GetComponent<Enemy_behavior>().TakeDamage();
        }
    }
}
