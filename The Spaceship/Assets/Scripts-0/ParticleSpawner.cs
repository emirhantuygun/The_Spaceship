using System.Collections;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public GameObject particle;
    public GameObject saturn;

    private void Start()
    {
        StartCoroutine(SpawnObject());
        InvokeRepeating("saturnspawner", 1, 3);
    }

    public IEnumerator SpawnObject()
    {
        while (true)
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
            Instantiate(particle, new Vector3(Random.Range(1f, 1.5f), Random.Range(-3f, 1), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(1.5f, 2f), Random.Range(1, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(2f, 2.5f), Random.Range(-3, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(2.5f, 3f), Random.Range(1f, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(3f, 3.5f), Random.Range(-3f, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(3.5f, 4f), Random.Range(1f, 5f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(4f, 4.5f), Random.Range(-3f, 1f), 40), Quaternion.identity);
            Instantiate(particle, new Vector3(Random.Range(4.5f, 5f), Random.Range(1f, 5f), 40), Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(0.2f, 0.5f));
        }
    }

    void saturnspawner()
    {
        Instantiate(saturn, new Vector3(Random.Range(-4, 4), Random.Range(-2.5f, 4), 40), Quaternion.identity);
    }
}