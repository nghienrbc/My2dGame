using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptySprite;
    public int pesosAmount = 5;
    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptySprite; 
            GameManager.instance.ShowText("+" + pesosAmount + " pesos", 25, Color.yellow, transform.position, Vector3.up * 30, 1.5f);
        }

    }
}
