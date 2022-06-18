using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public bool luz = false;
    public float recuperacaoDeVida = 3;
    public float vidaMax;
    public float dano = 1;
    public float vida = 100;

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
        if (vida > vidaMax) vida = vidaMax;
        if (vida < 0) vida = 0;
    }

    public void Dano(float dano) {
        vida -= dano;
        if (vida < 0) vida = 0;
    }
}