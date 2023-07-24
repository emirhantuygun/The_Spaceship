using System.Collections;
using UnityEngine;

public class ParticleMove : MonoBehaviour
{
    int min = 10, max = 30;
    bool works = false;

    private void Start()
    {
        Destroy(gameObject, 8);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.back * Random.Range(min, max) * Time.deltaTime;
        
        if (TimeSlowing.slowed == true)
        {
            if (works == false)
            {
                works = true;
                min = min / 2;
                max = max / 2;

                StartCoroutine(Timer());
            }
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(10f);
        {
            min = min * 2;
            max = max * 2;

            works = false;
        }
    }
}
