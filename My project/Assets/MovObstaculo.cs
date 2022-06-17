using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject paredeCol;
    private Rigidbody2D corpo;
    private bool ParaEsquerda = true;
    public float velocidade;
    void Start()
    {
        paredeCol = GameObject.FindWithTag("Parede");
        corpo = gameObject.GetComponent<Rigidbody2D>();
        corpo.velocity = Vector2.left * velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D paredeCol)
    {
        Debug.Log("Colidiu com a parede");
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
    }
}
