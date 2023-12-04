using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public GameObject m_fireBall = null; // Object the player can shoot
    [SerializeField] float timerShoot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerShoot += Time.deltaTime;

        if (timerShoot > 0.1f)
        {
            ShootFireball();
            timerShoot = 0f;
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
