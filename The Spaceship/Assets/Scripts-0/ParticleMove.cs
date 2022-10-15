using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMove : MonoBehaviour
{
    
    private void Start()
    {
        Destroy(gameObject, 8);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.back * Random.Range(15, 30) * Time.deltaTime;
    }

   


}
