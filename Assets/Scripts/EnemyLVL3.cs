using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLVL3 : MonoBehaviour
{
    [SerializeField] private ControllerDoor nextDoor;
    [SerializeField] private bool isGone;
    public bool smellPizza;
    public AIEnnemy ScriptEnemy;

    private void Start()
    {
        smellPizza = false;
        isGone = false;
    }
    // Update is called once per frame
    void Update()
    {

        if (smellPizza)
        {
            ScriptEnemy.Move();
            isGone = true;
        }

        if (isGone)
        {
            nextDoor.doorLock = false;
        }
    }
}
