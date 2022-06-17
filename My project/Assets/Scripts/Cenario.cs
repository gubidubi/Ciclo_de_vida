using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    public float height = 17.14f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -height) {
            transform.Translate(0f, 2f * height, 0f);
        }
    }
}
