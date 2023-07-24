using System.Collections;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour   
{ 
    GameObject planet;

    bool p2;
    bool p3;
    bool p4;
    bool p5;
    bool p6;
    bool p7;
    bool p8;

    public GameObject planet1;
    public GameObject planet2;
    public GameObject planet3;
    public GameObject planet4;
    public GameObject planet5;
    public GameObject planet6;
    public GameObject planet7;
    public GameObject planet8;
    
    float x = 0, y = 0;
    float range = 1.5f;
    float spawntime;
    bool works;
    int score;
    
    void Start()
    {
        Failing.isDead = false;

        works = false;
        planet = planet1;
        spawntime = 0.55f;

        StartCoroutine(SpawnObject());
    }

    public void Update()
    {
        if (!Failing.isDead)
        {
            x = VehicleGenerator.currentvehicle.transform.position.x;
            y = VehicleGenerator.currentvehicle.transform.position.y;
        }

        if (TimeSlowing.slowed == true)
        {
            if (works == false)
            {
                works = true;
                spawntime = spawntime * 2; 
                
                StartCoroutine(Timer());
            }
        }
        
        score = PlayerPrefs.GetInt("Score");
        
        if(score >= 20 && score < 45)
        {
            if(p2 == false) 
            {         
                p2 = true;
                planet = planet2;

                if (TimeSlowing.slowed == true)
                    spawntime = 0.50f * 2;
                else
                    spawntime = 0.50f;
            }
        }

        if (score >= 45 && score < 95)
        {
            if (p3 == false)
            {
                p3 = true;
                planet = planet3;

                if (TimeSlowing.slowed == true)
                    spawntime = 0.45f * 2;
                else
                    spawntime = 0.45f;
            }
        }

        if (score >= 95 && score < 145)
        {
            if(p4 == false)
            {
                p4 = true;
                planet = planet4;

                if (TimeSlowing.slowed == true)
                    spawntime = 0.40f * 2;
                else
                    spawntime = 0.40f;
            }
        }

        if (score >= 145 && score < 195)
        {
            if(p5 == false) 
            {
                p5 = true;
                planet = planet5;

                if (TimeSlowing.slowed == true)
                    spawntime = 0.35f * 2;
                else
                    spawntime = 0.35f;
            }
        }

        if (score >= 195 && score < 245)
        {
            if(p6 == false) 
            { 
                p6 = true;
                planet = planet6;

                if (TimeSlowing.slowed == true)
                    spawntime = 0.30f * 2;
                else
                    spawntime = 0.30f;
            }
        }

        if (score >= 245 && score < 295)
        {
            if(p7 == false) 
            { 
                p7 = true;
                planet = planet7;

                if (TimeSlowing.slowed == true)
                    spawntime = 0.25f * 2;
                else
                    spawntime = 0.25f;
            }
        }

        if (score >= 295)
        {
            if(p8 == false)
            {
                p8 = true;
                planet = planet8;
                
                if (TimeSlowing.slowed == true)
                    spawntime = 0.20f * 2;
                else
                    spawntime = 0.20f;
            }
        }
    }

    public IEnumerator SpawnObject()
    {
       while(!Failing.isDead)
       {       
            Instantiate(planet, new Vector3(Random.Range(x - range, x + range), Random.Range(y - range, y + range), 50), Quaternion.identity);
            
            yield return new WaitForSeconds(spawntime);
       }           
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(10f);
        {
            spawntime = spawntime / 2;
            works = false;
        }
    }
}
