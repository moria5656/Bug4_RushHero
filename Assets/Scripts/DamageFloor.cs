using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageFloor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)  //OnCollisionEnter(Collision other)ではない
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SendMessage("Damage");  
        }
    }
}
