using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource abeia;
    public AudioSource borboleta;

    public void PlayAbelhaSound(){
        abeia.Play();
    }

    public void PlayBorboletaSound(){
        borboleta.Play();
    }
}
