using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Componentes principais")]
    public Movimento player;
    public scrolling camera;
    private float playerNormalSpeedAux;
    private float cameraNormalSpeedAux;
    [Space]

    [Header("Game Over")]
    public GameOver gameOverScript;
    public Animator desceATela;
    public Animator textoInicial;
    [Space]

    private bool comecou = false;
    private bool morreu = false;

    [HideInInspector]
    public int pontuacao;
    
    private void Start(){
        pontuacao = 0;
        playerNormalSpeedAux = player.forca;
        player.forca = 0;
        cameraNormalSpeedAux = camera.velocidade;
        camera.velocidade = 0;
    }

    private void Update(){ //Inicialmente camera, cenario e arvore parados, até que o jogador pressione alguma tecla (usei a tecla E)
        if (Input.GetKeyDown(KeyCode.E) && !comecou){
            comecou = true;
            StartCoroutine(StartGame());
        }

        //atualizar a pontuação do jogador a cada frame se estiver vivo desde que ele iniciar o jogo
        if (!morreu && comecou){

        }

        if (ChecarMorte() && !morreu){
            morreu = true;
            StartCoroutine(Morrer());
        }
        

    }

    private IEnumerator StartGame(){
        player.forca = playerNormalSpeedAux;
        camera.velocidade = cameraNormalSpeedAux;
        //Começar uma musiquinha tbm

        //Ativar o sistema de spawn de inimigos e de galhos

        yield return new WaitForSeconds(0.5f);
        textoInicial.SetTrigger("sumir");
        yield return null;
    }

    private IEnumerator Morrer(){
        //Parar o spawn de inimigos
        player.forca = 0;
        //esconder oq tava antes
        gameOverScript.HideComponents();
        yield return new WaitForSeconds(1f);
        desceATela.SetTrigger("morreu");
        yield return new WaitForSeconds(1f);
        gameOverScript.OnDeath(pontuacao);

    }

    private bool ChecarMorte(){
        bool morto = false;
        if (Mathf.Abs(player.transform.position.y - camera.transform.position.y) >= 5){ //Jogador ta acima ou abaixo da camera
            Debug.Log("Jogador detectado fora dos limites. Morra imediatamente");
            morto = true;
        }
        //Checar morte por outros meios abaixo, se houver

        return morto;
    }
}
