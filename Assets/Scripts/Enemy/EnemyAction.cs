using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    float timer;
    float interval = 4.0f;
    public GameObject fireBall;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval) //<=ではなく逆向き
        {
            timer = 0;
            Instantiate(fireBall, transform.position, Quaternion.identity);
        }
    }
}
