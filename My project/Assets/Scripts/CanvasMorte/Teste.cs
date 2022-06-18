using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public int points;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            GameObject.Find("Scripts").GetComponent<GameOver>().OnDeath(points);
        }
    }
}
