using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDoor : MonoBehaviour
{
    [SerializeField] private Sprite closeDoor;
    [SerializeField] private Sprite openDoor;
    [SerializeField] private SpriteRenderer m_renderer;
    public bool doorLock;
    [SerializeField] private Collider2D box;

    // Start is called before the first frame update
    void Start()
    {
        m_renderer.sprite = closeDoor;
        doorLock = true;
    }

    // Update is called once per frame
    void Update()
    {
        ControlDoor();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.tag == "Player") && (!doorLock))
        {
            m_renderer.sprite = openDoor;
        }
    }

    public void ControlDoor()
    {
        if (doorLock)
        {
            box.isTrigger = false;
            m_renderer.sprite = closeDoor;
        }
        else
        {
            box.isTrigger = true;
            m_renderer.sprite = openDoor;
        }
    }
}
