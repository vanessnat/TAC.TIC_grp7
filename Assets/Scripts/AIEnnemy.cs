using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AIEnnemy : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] SpriteRenderer actualSprite;
    [SerializeField] Sprite defaultSprite;
    [SerializeField] Sprite moveSprite;

    public Transform[] waypoints;
    private Transform target;
    private int destPoint;

    void Start()
    {
        target = waypoints[0];
        speed = 100f;
    }

    void Update()
    {
        Move();
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
            actualSprite.flipX = !actualSprite.flipX;
        }
    }
}
    /*public float attackCooldown = 1.5f; // Délai entre chaque attaque
    public Transform target; // Référence au joueur (à définir dans l'éditeur Unity)

    private bool canAttack = true;

    private void Update()
    {
        if (canAttack)
        {
            Attack(); // Appelle la fonction d'attaque si l'ennemi peut attaquer
        }
    }

    void Attack()
    {
        // Code pour que l'ennemi attaque le joueur
        // Par exemple, vous pouvez utiliser la méthode de détection de collision avec un collider pour vérifier si le joueur est touché

        // Pour cet exemple, je vais supposer que l'ennemi a un collider et qu'il détecte la balle du joueur
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, 1f, LayerMask.GetMask("Fire"));

        foreach (Collider2D collider in hitColliders)
        {
            // Si l'ennemi détecte la balle du joueur
            // Vous pouvez mettre ici le code pour infliger des dégâts au joueur par exemple
            Debug.Log("Enemy hit by player bullet!");
            canAttack = false; // Empêche l'ennemi d'attaquer pendant un court moment après avoir été touché
            Invoke("ResetAttack", attackCooldown); // Réactive l'attaque après le délai défini
        }
    }

    void ResetAttack()
    {
        canAttack = true; // Réactive l'attaque de l'ennemi
    }
}*/