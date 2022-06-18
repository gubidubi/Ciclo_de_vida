using UnityEngine;

public class SpawnDeFolhas : MonoBehaviour
{
    public GameObject folhaPequena; //prefab
    public Transform camera;
    public float SpawnTime;
    private float timeCounter;

    private void Start(){
        timeCounter = 0f;
    }
    
    private void Update(){
        
        if (timeCounter > SpawnTime){
            timeCounter = 0f;
            SpawnSingleFolha();
        }
        timeCounter += Time.deltaTime;
    }

    private void SpawnSingleFolha(){
        //escolher posição -> y acima de onde a camera ta vendo (cam position + 5 + ...)
        float y = Random.Range(camera.position.y + 5f, camera.position.y + 10f);
        float x = Random.Range(-9f, 9f);
        GameObject novo = Instantiate(folhaPequena, new Vector3(x,y,0), Quaternion.identity);
        Destroy(novo,120); //Só pra n acumular muitas folhas
    }
}
