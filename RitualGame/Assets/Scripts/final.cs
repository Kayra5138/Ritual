using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class final : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        panel.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        panel.SetActive(true);

    }
}
