using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player") && (Input.GetKeyDown(KeyCode.Escape)))
        {
/*            if(FrigoController.)
*/        }
    }
}
