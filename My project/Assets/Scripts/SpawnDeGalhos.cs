using UnityEngine;

public class SpawnDeGalhos : MonoBehaviour
{
    public GameObject galho; //prefab
    public Transform camera;
    public float SpawnTime;

    private float timeCounter;

    private void Start(){
        timeCounter = 0f;
    }
    
    private void Update(){
        
        if (timeCounter > SpawnTime){
            timeCounter = 0f;
            SpawnSingleGalho();
        }
        timeCounter += Time.deltaTime;
    }

    public void SpawnSingleGalho(){
        //escolher posição -> y acima de onde a camera ta vendo (cam position + 5 + ...)
        float y = Random.Range(camera.position.y + 10f, camera.position.y + 15f);
        float x = Random.Range(-9f, 9f);
        //escolher orientação
        float rotacao = Random.Range(0f, 360f);
        //escolher tamanho
        float escala = Random.Range(1f, 2.4f);
        //Instanciar
        GameObject novo = Instantiate(galho, new Vector3(x,y,0), Quaternion.Euler(0,0,rotacao));
        novo.transform.localScale =  new Vector3(escala,escala,1);
        Destroy(novo,30); //Só pra n acumular muitos galhos
    }
}
