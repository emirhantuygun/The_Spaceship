using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetMove3 : MonoBehaviour
{
    public GameObject spaceship;
    public float speed = 25;
  

    private void Start()
    {
        Destroy(gameObject, 5);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }

    
    private void OnCollisionEnter(Collision spaceship)
    {
        speed = 1;
        StartCoroutine(Timer());
    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.5f);
        {
            SceneManager.LoadScene("MainMenu");
            speed = 25;
        }
    }
    
   
}
