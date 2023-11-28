using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDoor : MonoBehaviour
{
    [SerializeField] private Sprite closeDoor;
    [SerializeField] private Sprite openDoor;
    [SerializeField] private SpriteRenderer m_renderer;
    [SerializeField] private bool doorLock = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.tag == "Player") && (!doorLock))
        {
            m_renderer.sprite = openDoor;
        }
    }
}
