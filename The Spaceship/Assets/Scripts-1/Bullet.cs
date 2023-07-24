using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3f;
    public GameObject explosion;
    public static bool weaponscore;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision planet)
    {
        if (planet.collider.tag == "Planets")
        {
            Destroy(gameObject);
            Destroy(planet.gameObject);
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            weaponscore = true;
        }
    }
}
