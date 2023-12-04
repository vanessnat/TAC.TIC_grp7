using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargetControl : MonoBehaviour
{
    public int overload;
    public bool isOverload = false;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] GameObject boss;
    [SerializeField] SpriteRenderer bossSprite;
    Color firstRed = new Color(1.0f, 0.5f, 0.5f);
    Color secondRed = new Color(0.5f, 0.2f, 0.2f);
    Color thirdRed = new Color(0.7f, 0.1f, 0.1f);
    Color maxRed = new Color(1.0f, 0.0f, 0.0f);
    Color off = new Color(1.0f, 0.0f, 0.0f, 0.2f);

    // Start is called before the first frame update
    void Start()
    {
        overload = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.CompareTag("Fireball"))&&!isOverload) {

            overload++;
            Destroy(collision.gameObject);

            switch (overload)
            {
                case 0: 
                    spriteRenderer.color = Color.white;
                    bossSprite.color = Color.white;
                    break;
                case 1: 
                    spriteRenderer.color = firstRed;
                    bossSprite.color = firstRed;
                    break;
                case 2:
                    spriteRenderer.color = secondRed;
                    bossSprite.color = secondRed;
                    break;
                case 3:
                    spriteRenderer.color = thirdRed;
                    bossSprite.color = thirdRed;
                    break;
                case 4:
                    spriteRenderer.color = maxRed;
                    bossSprite.color = maxRed;
                    break;

                default: 
                    spriteRenderer.color = off;
                    isOverload = true;
                    Destroy(boss);
                    break;
            }
        }
    }
}
