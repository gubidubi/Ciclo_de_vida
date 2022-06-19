using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public void Continue(){
        if (GameObject.Find("Game_Management").GetComponent<GameManager>().pontuacao > 100){
            SceneManager.LoadScene("Transicao");
        }
        else{
            SceneManager.LoadScene("Main");
        }
    }

    public void GiveUp(){
        Application.Quit();
    }
}
