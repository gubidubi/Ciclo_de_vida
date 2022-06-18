using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMove : MonoBehaviour
{
    private Rigidbody2D corpo;
    private GameObject player;
      private Vector2 target;
    private Vector2 position;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        corpo = gameObject.GetComponent<Rigidbody2D>();

        target = new Vector2(0.0f, 0.0f);
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
}
