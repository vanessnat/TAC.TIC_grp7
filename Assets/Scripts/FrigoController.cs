using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrigoController : MonoBehaviour
{
    public bool getPizza;


    private void Start()
    {
        getPizza = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            /*if (Input.GetKeyDown(KeyCode.Space))
            {*/
                getPizza = true;
            //}
        }
    }
}
