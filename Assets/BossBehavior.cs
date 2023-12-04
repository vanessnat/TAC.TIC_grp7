using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public GameObject m_fireBall = null; // Object the player can shoot
    [SerializeField] float timerShoot = 0f;
    [SerializeField] float timing = 0f;
    [SerializeField] float speed;
    [SerializeField] SpriteRenderer actualSprite;
    [SerializeField] Sprite rightSprite;

    public Transform[] waypoints;
    private Transform target;
    private int destPoint;

    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[0];
        speed = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        timerShoot += Time.deltaTime;
        timing += Time.deltaTime;



        if (timing > 1f)
        {
            Move();
            if (timing > 4f)
            {
                timing = 0f;
            }
        }
        else
        {
            if (timerShoot > 0.1f)
            {
                ShootFireball();
                timerShoot = 0f;
            }
        }


    }
    
    void Move()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
        }
    }
    private void ShootFireball()
    {
        GameObject newFireball = Instantiate(m_fireBall, this.transform) as GameObject;

        // Accéder au composant Renderer du projectile
        Renderer fireballRenderer = newFireball.GetComponent<Renderer>();

        if (fireballRenderer != null)
        {
            // Changer la couleur du matériau
            fireballRenderer.material.color = new Color(1.0f, 0.0f, 0.0f, 0.5f); // Rouge avec 50% de transparence
        }

        FireBehavior fireBallBehavior = newFireball.GetComponent<FireBehavior>();

        if (fireBallBehavior != null)
        {
            fireBallBehavior.Launch(new Vector2(0f, -1f));
        }
    }

    
}
