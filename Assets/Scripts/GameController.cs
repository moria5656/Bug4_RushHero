using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    int count = 0;
    public GameObject clearText;
    public bool isPlaying = true;

    // ーーーーーーー修正機能３「if文に入らない」ーーーーーーーーーーーーーー
    void Update() //void Startだとゲーム開始後一回しか行われないので
    {
        if (isPlaying == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Main");
            }
        }
    }

    public void Count()
    {
        count++;
        Debug.Log("GameController Count: " + count);

        if (count >= 3)
        {
            Clear();
        }
    }

    public void Clear()
    {
        clearText.SetActive(true);
        isPlaying = false;
    }
}
