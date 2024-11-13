using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    public float offsetX = 17;
    public int floorSpeed;
    
    void Update()
    {
        transform.position -= new Vector3(floorSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -offsetX)
        {
            transform.position=new Vector3(offsetX, transform.position.y, 0);
        }
    }
}
