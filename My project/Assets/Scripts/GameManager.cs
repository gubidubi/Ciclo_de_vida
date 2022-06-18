using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Componentes principais")]
    public Movimento player;
    public scrolling camera;
    public BarraVida barra;
    private float playerNormalSpeedAux;
    private float cameraNormalSpeedAux;
    [Space]

    [Header("Game Over")]
    public GameOver gameOverScript;
    public Animator desceATela;
    public Animator textoInicial;
    [Space]

    [Header("Spawners")]
    public SpawnDeGalhos spawner;
    public SpawnDeFolhas folhas;

    private bool comecou = false;
    private bool morreu = false;

    [HideInInspector]
    public int pontuacao; //poderá ser acessado pelo script de coletar folhas, pra aumentar a pontuação
    
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

        //Ativar os sistemas de spawn
        spawner.enabled = true;
        folhas.enabled = true;

        //Ja pode perder vida
        barra.enabled = true;
        player.gameObject.GetComponent<Vida>().enabled = true;

        yield return new WaitForSeconds(0.5f);
        textoInicial.SetTrigger("sumir");
        yield return null;
    }

    private IEnumerator Morrer(){
        //Parar os spawners
        spawner.enabled = false;
        folhas.enabled = false;
        //Parar o jogador e sua vida
        player.forca = 0;
        barra.enabled = false;
        player.gameObject.GetComponent<Vida>().enabled = false;

        //esconder oq tava antes na telinha de game over
        gameOverScript.HideComponents();
        yield return new WaitForSeconds(1f);
        //Descer a tela
        desceATela.SetTrigger("morreu");
        yield return new WaitForSeconds(1f);
        //Continua o processo de morte
        gameOverScript.OnDeath(pontuacao);

    }

    private bool ChecarMorte(){
        bool morto = false;
        if (Mathf.Abs(player.transform.position.y - camera.transform.position.y) >= 5){ //Jogador ta acima ou abaixo da camera
            Debug.Log("Jogador detectado fora dos limites. Morra imediatamente");
            morto = true;
        }
        //Checar morte por outros meios abaixo, se houver
        if (player.gameObject.GetComponent<Vida>().vida <= 0 ){
            Debug.Log("Jogador morto por ter sua vida anulada"); 
            morto = true;
        }
        return morto;
    }
}
