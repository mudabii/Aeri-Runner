using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float speed = 3f;
    


    void Update()
    {
        transform.position -= new Vector3(speed * (Time.deltaTime), 0, 0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            
            Destroy(this.gameObject);
        }

    }
    }

