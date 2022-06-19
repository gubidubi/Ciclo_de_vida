using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutMachuca : MonoBehaviour
{

    public GameObject jogadorCol;
    private Vida vidaDoJogador;
    private Rigidbody2D corpo;
    

    // Start is called before the first frame update
    void Start()
    {
        vidaDoJogador = jogadorCol.GetComponent<Vida>();
        jogadorCol = GameObject.FindWithTag("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    private void OnCollisionEnter(Collision jogadorCol)
    {
      
    //funcaodano
    }
}
