using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour
{
    float hp = 8.0f;
    public PlayerUIManager playerUIManager;

    void Start()
    {
        playerUIManager.UpdateStatus(hp);
    }

    public void Damage()
    {
        hp--;
        playerUIManager.UpdateStatus(hp);

        if (hp <= 0)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
