using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyLVL3 : MonoBehaviour
{
    [SerializeField] private ControllerDoor nextDoor;
    [SerializeField] private bool isGone;
    public bool smellPizza;

    [SerializeField] float speed;

    [SerializeField] SpriteRenderer actualSprite;
    [SerializeField] Sprite defaultSprite;
    [SerializeField] Sprite moveSprite;

    public Transform[] waypoints;
    private Transform target;
    private int destPoint;


    private void Start()
    {
        smellPizza = false;
        isGone = false;
        target = waypoints[0];
        speed = 50f;
    }
    // Update is called once per frame
    void Update()
    {

        if (smellPizza)
        {
            Move();
            isGone = true;
        }

        if (isGone)
        {
            nextDoor.doorLock = false;
        }
    }
    public void Move()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            actualSprite.sprite = moveSprite;
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
        }
    }
}
