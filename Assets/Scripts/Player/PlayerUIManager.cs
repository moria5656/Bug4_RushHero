using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIManager : MonoBehaviour
{
    public Text hpText;

    public void UpdateStatus(float hp)
    {
        hpText.text = "HP:" + hp.ToString("F0");
    }
}
