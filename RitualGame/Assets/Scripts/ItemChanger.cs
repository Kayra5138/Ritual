using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChanger : MonoBehaviour
{
    [SerializeField] List<GameObject> sprites;
    bool canFire;
    bool isLit;
    GameObject fire;
    public float timeToLit = 3f;
    private float timeToLitDefault = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canFire && !isLit) {
            timeToLit -= Time.deltaTime;

            if (timeToLit <= 0) {
                Debug.Log("Yandı");
                isLit = true;
                sprites[0].SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire")
        {
            Debug.Log("Fire enter");
            canFire = true;
            fire = other.gameObject;
            timeToLitDefault = timeToLit;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire")
        {
            Debug.Log("Fire leave");
            canFire = false;
            timeToLit = timeToLitDefault;
        }
    }
}
