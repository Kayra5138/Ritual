using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D cl;
    GameObject player;
    [SerializeField] Vector3 positionOffset;
    [SerializeField] bool moveWithMouse;
    bool canPickUp;
    bool isPickedUp;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cl = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isPickedUp && canPickUp) {
                isPickedUp = true;
            } else if (isPickedUp) {
                isPickedUp = false;
            }

            if (isPickedUp)
            {
                Debug.Log("İtemi aldı!");
                cl.isTrigger = true;
            }
            else
            {
                Debug.Log("İtemi bıraktı!");
                cl.isTrigger = false;
                player = null;
            }
        }

        if (isPickedUp)
        {
            transform.position = player.transform.position + positionOffset;

            if (moveWithMouse)
            {
                // convert mouse position into world coordinates
                Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                // get direction you want to point at
                Vector2 direction = (mouseScreenPosition - (Vector2)transform.position).normalized;
                // set vector of transform directly
                transform.up = direction;
            } else {
                transform.rotation = Quaternion.identity;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player enter");
            canPickUp = true;
            player = other.gameObject;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player leave");
            canPickUp = false;
        }
    }
}
