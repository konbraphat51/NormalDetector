using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByKey : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.up.normalized*speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.up.normalized*speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.right.normalized*speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.right.normalized*speed);
        }
    }
}
