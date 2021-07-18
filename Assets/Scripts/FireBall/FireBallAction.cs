using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallAction : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //ーーーーーー修正機能「SendMessageができない」ーーーーーーー
            other.gameObject.SendMessage("Damage");　//damageをDamageになおす
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
