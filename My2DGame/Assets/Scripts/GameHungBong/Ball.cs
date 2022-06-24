using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gc;
    // Start is called before the first frame update
    void Start()
    { 
        Debug.Log("start");
        m_gc = FindObjectOfType<GameController>();
    } 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("da cham table");
            m_gc.IncreaseScore();
            Destroy(gameObject);
        } 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.CompareTag("DeathZone"))
        {
            m_gc.SetGameOverState(true);
            Destroy(gameObject);

            Debug.Log("da trigger DeathZone");
        }
    }
}
