using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    int hp = 3;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") //playerになってしまっていた
        {
            if (hp >= 2)
            {
                hp--;
                Debug.Log("Enemy HP : " + hp);
            }
            else
            {
                Destroy(this.gameObject);
                GameObject.FindWithTag("GameController").SendMessage("Count");
            }
        }
    }
}
