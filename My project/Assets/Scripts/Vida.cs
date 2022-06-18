using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public bool luz = false;
    public double recuperacaoDeVida = 3;
    public double dano = 1;
    public double vida = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (luz) {
            vida += recuperacaoDeVida * Time.deltaTime;
        } else {
            vida -= dano * Time.deltaTime;
        }
        Debug.Log(vida);
    }
}
