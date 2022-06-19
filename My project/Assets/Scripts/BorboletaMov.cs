using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorboletaMov : MonoBehaviour
{
    private GameObject jogadorCol;
    private Rigidbody2D corpo;
    private Vector2 target;
    public float speed = 5f;
    float step;
    public Animator anim ;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        corpo = gameObject.GetComponent<Rigidbody2D>();
        target = transform.position;
        StartCoroutine("movAleatoria");
        jogadorCol = GameObject.FindWithTag("Player");

    }
    
    IEnumerator movAleatoria()
    {
        yield return new WaitForSeconds(0.5f); //Ou qualquer outro segundo
        
        float xvel = Random.Range(-1f,1f);
        float yvel = Random.Range(-Mathf.Sqrt(1 - xvel*xvel),Mathf.Sqrt(1 - xvel*xvel));
        corpo.velocity = speed * new Vector2(xvel, yvel);
        if(yvel > 0)
        {
            if(xvel > 0)
                anim.SetBool("BorboletaEsq",false);
            else anim.SetBool("BorboletaEsq",true);
            anim.SetBool("BorboletaBaixo",false);
        }
        else anim.SetBool("BorboletaBaixo",true);

        StartCoroutine("movAleatoria");
  
    }
    // Update is called once per frame
    void Update()
    {
        
       


      /*  step = speed * Time.deltaTime; // calculate distance to move
        transform.position = transform.position = Vector2.MoveTowards(transform.position, target, step);

        // Check if the position of the cube and sphere are approximately equal.
        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            target = transform.position + new Vector3(Random.Range(-3.0f, 3.0f),Random.Range(-3.0f, 3.0f), 0);
        }*/
    }

    void OnCollisionEnter2D(Collision2D obj)
    {

    }
}
