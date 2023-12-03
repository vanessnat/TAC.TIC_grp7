using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer m_renderer;
    [SerializeField] private Sprite chestOpen;
    [SerializeField] private Sprite chestClose;
    [SerializeField] private ControllerDoor door;
    // Start is called before the first frame update
    void Start()
    {
        m_renderer.sprite = chestClose;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void OpenChest()
    {
        m_renderer.sprite = chestOpen;
        door.doorLock = false;
    }
}
