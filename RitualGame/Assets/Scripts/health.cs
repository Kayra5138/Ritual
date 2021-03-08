using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float Health = 10f;
    public GameObject blood;
    private bool once_check;

    private void Start()
    {
        once_check = false;
    }

    private void Update()
    {
        if(Health <=0)
        {
            Destroy(gameObject,3.5f);
            if(!once_check)
            {
                Instantiate(blood, gameObject.transform.position, Quaternion.identity);
                once_check = true;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("knife"))
        {
            Health -= 2f;
        }
    }
}
