using System;
using UnityEngine;

public class Failing : MonoBehaviour
{
    public GameObject explosion;   
    public static bool isDead;

    int fuelcost, cash, newcash, counter;
    float fuel;

    private void OnCollisionEnter(Collision planet)
    {
        if (planet.collider.tag == "Planets")
        { 
            isDead = true;
            TimeSlowing.slowed = false;

            if (PlayerPrefs.GetInt("Score", 0) >= 30)
            {
                counter = PlayerPrefs.GetInt("adcounter", 0);
                PlayerPrefs.SetInt("adcounter", counter + 1);
            }

            fuel = (PlayerPrefs.GetInt("Score", 0) * (55 - PlayerPrefs.GetInt("fuel", 1) * 5)) / 100f;
            fuelcost = (int)MathF.Ceiling(fuel);
            PlayerPrefs.SetInt("fuelcost", fuelcost);

            cash = PlayerPrefs.GetInt("cash", 0);
            newcash = PlayerPrefs.GetInt("Score", 0) - fuelcost;
            PlayerPrefs.SetInt("newcash", newcash);
            PlayerPrefs.SetInt("cash", newcash + cash);

            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);   
        }  
    }
}