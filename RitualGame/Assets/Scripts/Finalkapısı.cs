using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finalkapısı : MonoBehaviour
{
    public GameObject sliderObject;
    Slider slider;
    

    // Start is called before the first frame update
    void Start()
    {
        slider = sliderObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if( slider.value == slider.maxValue)
        {
            Destroy(gameObject);
            
        }
    }
    
}
