using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourController : MonoBehaviour
{
    public FrigoController Frigo;
    public EnemyLVL3 Enemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            /*if (Input.GetKeyDown(KeyCode.Space))
            {*/
                if (Frigo.getPizza)
                {
                    Enemy.smellPizza = true;
                }
            //}
        }
    }
}
