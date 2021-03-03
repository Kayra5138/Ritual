using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    [SerializeField] ItemChanger itemChanger;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire")
        {
            Debug.Log("Fire enter");
            itemChanger.canFire = true;
            itemChanger.fire = other.gameObject;
            itemChanger.timeToLitDefault = itemChanger.timeToLit;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire")
        {
            Debug.Log("Fire leave");
            itemChanger.canFire = false;
            itemChanger.timeToLit = itemChanger.timeToLitDefault;
        }
    }
}
