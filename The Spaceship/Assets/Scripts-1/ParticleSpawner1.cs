using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner1 : MonoBehaviour
{
    public GameObject particle;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    public IEnumerator SpawnObject()
    {
        while (1 == 1)
        {
            Instantiate(particle, new Vector3(Random.Range(-5f, -4.5f), Random.Range(-3, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(-4.5f, -4f), Random.Range(1, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(-4f, -3.5f), Random.Range(-3, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(-3.5f, -3f), Random.Range(1, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(-3f, -2.5f), Random.Range(-3, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(-2.5f, -2f), Random.Range(1, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(-2f, -1.5f), Random.Range(-3f, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(-1.5f, -1f), Random.Range(1f, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(-1f, -0.5f), Random.Range(-3f, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(-0.5f, 0f), Random.Range(1f, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(0f, 0.5f), Random.Range(-3f, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(0.5f, 1f), Random.Range(1f, 5), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(1f, 1.5f), Random.Range(-3, 1), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(1.5f, 2f), Random.Range(1, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(2f, 2.5f), Random.Range(-3, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(2.5f, 3f), Random.Range(1f, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(3f, 3.5f), Random.Range(-3f, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(3.5f, 4f), Random.Range(1f, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(4f, 4.5f), Random.Range(-3f, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(4.5f, 5f), Random.Range(1f, 5f), 40), Quaternion.identity);


            yield return new WaitForSeconds(Random.Range(0.5f, 1f));

        }

    }
}