using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItem : MonoBehaviour
{
    [SerializeField] private SpriteRenderer m_renderer;
    [SerializeField] public Sprite ItemOpen;
    [SerializeField] public Sprite ItemClose;

    bool playerIsInFront = false;

    void Start()
    {
        m_renderer.sprite = ItemClose;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerIsInFront)
        {
            if (m_renderer.sprite == ItemClose)
            {
                m_renderer.sprite = ItemOpen;
            }
            else {
                if (m_renderer.sprite == ItemOpen)
                {
                  //  m_renderer.sprite = ItemClose;
                }
            }
        }
    }

     void OnTriggerEnter2D(Collider2D col)
    {
       playerIsInFront = true;
    }

     void OnTriggerExit2D(Collider2D col)
    {
       playerIsInFront = false;
    }

    /*public void ItemOpen()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
            if (m_renderer.sprite == ItemOpen)
            {
                m_renderer.sprite = ItemClose;
            }
        }
    }

    public void ItemClose()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (m_renderer.sprite == ItemClose)
            {
                m_renderer.sprite = ItemOpen;
            }
        }
    }
    */
}