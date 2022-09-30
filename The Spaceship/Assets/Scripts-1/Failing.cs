using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Failing : MonoBehaviour
{
    public GameObject planet;
    public GameObject explosion;
    SMovement a;

    private void Start()
    {
        a = GetComponent<SMovement>();
    }

    private void OnCollisionEnter(Collision planet)
    {
        a.isDead = true;
        Destroy(this.gameObject);
        Instantiate(explosion, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }

    
}