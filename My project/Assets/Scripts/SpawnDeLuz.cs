using UnityEngine;

public class SpawnDeLuz : MonoBehaviour
{
    public GameObject luz; //prefab
    public Transform camera;
    public float SpawnTime;

    private float timeCounter;

    private void Start(){
        timeCounter = 0f;
    }
    
    private void Update(){
        
        if (timeCounter > SpawnTime){
            timeCounter = 0f;
            SpawnSingleluz();
        }
        timeCounter += Time.deltaTime;
    }

    public void SpawnSingleluz(){
        //escolher posição -> y acima de onde a camera ta vendo (cam position + 5 + ...)
        float y = Random.Range(camera.position.y + 12.5f, camera.position.y + 25f);
        float x = -1;
        //escolher orientação
        float rotacao = 40f;
        //escolher tamanho
        GameObject novo = Instantiate(luz, new Vector3(x,y,0.55f), Quaternion.Euler(0,0,rotacao));
        Destroy(novo, 120); //Só pra n acumular muitos luzs
    }
}
