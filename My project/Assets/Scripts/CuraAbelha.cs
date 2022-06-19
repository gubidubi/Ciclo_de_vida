using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuraAbelha : MonoBehaviour
{
    private GameObject jogadorCol;
    public float cura;
    private Vida vidaDoJogador;
    // Start is called before the first frame update
    void Start()
    {
        jogadorCol = GameObject.FindWithTag("Player"); 
        vidaDoJogador = jogadorCol.GetComponent<Vida>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D jogadorCol2)
    {
        if (jogadorCol2.gameObject == jogadorCol) {
            vidaDoJogador.Dano(-cura);
            Destroy(gameObject);
        }
    }
}
