using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLVL3 : MonoBehaviour
{
    [SerializeField] private ControllerDoor nextDoor;
    [SerializeField] private bool isGone = false;
    [SerializeField] private bool smellPizza = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGone)
        {
            nextDoor.doorLock = false;
        }

        if (smellPizza)
        {

        }
    }
}
