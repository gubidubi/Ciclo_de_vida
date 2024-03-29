using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutMachuca : MonoBehaviour
{

    private GameObject jogadorCol;
    private Vida vidaDoJogador;
    private Rigidbody2D corpo;
    private bool deuDano = false;
    

    // Start is called before the first frame update
    void Start()
    {
        jogadorCol = GameObject.FindWithTag("Player"); 
        vidaDoJogador = jogadorCol.GetComponent<Vida>();
        deuDano = false;
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
    private void OnCollisionEnter2D(Collision2D jogadorCol2)
    {
        if (jogadorCol2.gameObject == jogadorCol) {
            if (!deuDano) {
                deuDano = true;
                vidaDoJogador.Dano(20);
            }
        }
    }
}
