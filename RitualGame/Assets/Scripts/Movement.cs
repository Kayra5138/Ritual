using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] List<Sprite> sprites;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        if (yAxis < 0)
        {
            spriteRenderer.sprite = sprites[0];
        }
        else if (yAxis > 0)
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (xAxis > 0)
        {
            spriteRenderer.sprite = sprites[2];
        }
        else if (xAxis < 0)
        {
            spriteRenderer.sprite = sprites[3];
        }

        transform.Translate(new Vector2(xAxis, yAxis) * Time.fixedDeltaTime * moveSpeed);
        //rb.AddRelativeForce(new Vector2(xAxis, yAxis)*Time.fixedDeltaTime*moveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

    }
}
