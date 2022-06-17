using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling : MonoBehaviour
{
    public float velocidade = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(velocidade * Vector3.up * Time.deltaTime);
    }
}
