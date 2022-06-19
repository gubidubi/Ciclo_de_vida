using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMove : MonoBehaviour
{
    
    private Rigidbody2D corpo;
    private GameObject player;
      private Vector2 target;
    private Vector2 position;
    public Animator anim ;

    public float w;
    public float R;
    public float TETA0;
    private float vx, vy;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        corpo = gameObject.GetComponent<Rigidbody2D>();

        TETA0 = 0;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        vy = w*R*Mathf.Cos(TETA0 + w*Time.time);
        vx = w*R*Mathf.Sin(TETA0 + w*Time.time);
        corpo.velocity = new Vector2(vx,vy);
        if(vx > 0)
            anim.SetBool("abelhaDireita",true);
        else anim.SetBool("abelhaDireita",false);
    }

    
}
