using UnityEngine;

public class ColetarFolhas : MonoBehaviour
{
    public GameObject folhaGrande;
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            Vector3 posicao = other.gameObject.transform.position;
            Vector3 velocidade = other.gameObject.GetComponent<Rigidbody2D>().velocity;
            GameObject novo = Instantiate(folhaGrande, posicao, Quaternion.Euler(0,0,90 + 180 * Mathf.Atan(velocidade.y/velocidade.x)/Mathf.PI)); //Tem que ter a inclinação do jogador
            Destroy(novo, 30); //Pra nao acumular
            Destroy(gameObject);
        }
    }
}
