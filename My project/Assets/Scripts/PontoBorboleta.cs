using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontoBorboleta : MonoBehaviour
{
    public int pontos;
    private GameObject jogadorCol;
    private GameObject game_Manager;
    private GameManager script;
    // Start is called before the first frame update
    void Start()
    {
        game_Manager = GameObject.Find("Game_Management");
        jogadorCol = GameObject.FindWithTag("Player");
        script = game_Manager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D jogadorCol2)
    {
        if (jogadorCol2.gameObject == jogadorCol) {
            GameObject.Find("AllSounds").GetComponent<SoundPlayer>().PlayBorboletaSound();
            script.pontuacao += pontos;
            Destroy(gameObject);
        }
    }
}
