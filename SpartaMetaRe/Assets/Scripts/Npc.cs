using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{
    public string line = "Hellow";
    public Text uiText;

    void OnTriggerEnter2D(Collider2D other)
    {
        uiText.text = line;
        uiText.gameObject.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        uiText.gameObject.SetActive(false);
    }

}
