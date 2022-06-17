using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject paredeCol;
    private Rigidbody2D corpo;
    private bool ParaEsquerda = true;
    public float velocidade = 0;
    void Start()
    {
        corpo = gameObject.GetComponent<Rigidbody2D>();
        paredeCol = GameObject.FindWithTag("Parede");
        

        corpo.velocity = Vector2.left * velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnCollisionEnter2D(Collision2D paredeCol)
    {
        if(ParaEsquerda)
        {
            corpo.velocity = Vector2.right * velocidade;
            ParaEsquerda = false;
        }
        else
        {
            corpo.velocity = Vector2.left * velocidade;
            ParaEsquerda = true;
        }
        Debug.Log("Bateu\n");
    }
}
