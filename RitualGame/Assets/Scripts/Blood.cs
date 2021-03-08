using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blood : MonoBehaviour
{
    public GameObject sliderObject;
    Slider slider;
    AudioSource au;

    // Start is called before the first frame update
    void Start()
    {
        slider = sliderObject.GetComponent<Slider>();
        au = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Player"))
        {
            slider.value += 10f;
            Destroy(gameObject);
            au.Play();
        }
    }
}
