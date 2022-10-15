using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner3 : MonoBehaviour   
{

    public SMovement a;
    public GameObject Planets;

    
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    public IEnumerator SpawnObject()
    {
       while(!a.isDead)
        {
            Instantiate(Planets, new Vector3(Random.Range(-2.5f, -1f), Random.Range(2f, 3.5f), 40), Quaternion.identity);
            Instantiate(Planets, new Vector3(Random.Range(1f, 2.5f), Random.Range(2f, 3.5f), 40), Quaternion.identity);


            if (Planets.transform.position.y <= 3f && Planets.transform.position.y >= 2f)
            {
                Instantiate(Planets, new Vector3(Random.Range(-2.5f, -1f), Random.Range(-3f, -1f), 40), Quaternion.identity);
                Instantiate(Planets, new Vector3(Random.Range(1f, 2.5f), Random.Range(-3f, -1f), 40), Quaternion.identity);
            }

            else
            {
                Instantiate(Planets, new Vector3(Random.Range(-2.5f, -1f), Random.Range(-2f, 0.5f), 40), Quaternion.identity);
                Instantiate(Planets, new Vector3(Random.Range(1f, 2.5f), Random.Range(-2f, 0.5f), 40), Quaternion.identity);
            }


            yield return new WaitForSeconds(0.65f);
        }     
        
    }








}
