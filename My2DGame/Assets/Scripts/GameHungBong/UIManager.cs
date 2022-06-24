using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject panel;
    public Text scoreText;
    // Start is called before the first frame update
    public void SetScoreText(string txt)
    {
        if (scoreText) scoreText.text = txt;
    }
    public void ShowPanel(bool isShow)
    {
        if (panel) panel.SetActive(isShow);
    }
}
