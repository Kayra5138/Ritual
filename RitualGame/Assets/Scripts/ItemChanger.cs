using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChanger : MonoBehaviour
{
    [SerializeField] List<Sprite> sprites;
    public bool canFire;
    public bool isLit;
    public GameObject fire;
    public float timeToLit = 3f;
    public float timeToLitDefault = 3f;

    public float spriteTimer = 0.25f;

    SpriteRenderer spriteRenderer;

    int id = 1;
    float timer = 0f;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (canFire && !isLit)
        {
            timeToLit -= Time.deltaTime;

            if (timeToLit <= 0)
            {
                Debug.Log("Yandı");
                isLit = true;
            }
        }

        timer += Time.deltaTime;

        if (isLit && timer >= spriteTimer)
        {
            spriteRenderer.sprite = sprites[id];

            if (id < sprites.Count - 2)
                id++;
            else
                id = 1;

            timer = 0f;
        }
    }


}
