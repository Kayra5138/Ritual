using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float moveSpeed= 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(xAxis, yAxis)* Time.fixedDeltaTime * moveSpeed);
        //rb.AddRelativeForce(new Vector2(xAxis, yAxis)*Time.fixedDeltaTime*moveSpeed);
    }
}
