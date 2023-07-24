using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlanetMove : MonoBehaviour
{
    float speed;
    int score;
    bool collision;
  
    private void Start()
    {
        speed = 20;
        collision = false;
    }

    void FixedUpdate()
    {
        score = PlayerPrefs.GetInt("Score");

        if(score >= 0 && score < 20)
            speed = 20;

        if (score >= 20 && score < 45)
            speed = 23;
        
        if(score >= 45 && score < 95)
            speed = 27;
        
        if(score >= 95 && score < 145)
            speed = 30;
        
        if(score >= 145 && score < 195)
            speed = 33;
        
        if(score >= 195 && score < 245)
            speed = 37;
        
        if(score >= 245 && score < 295)
            speed = 40;
        
        if(score >= 295)
            speed = 43;     

        if(TimeSlowing.slowed == true)
            speed = speed / 2;
        
        if(collision == true)
            speed = 1;       

        transform.position += Vector3.back * speed * Time.deltaTime;
    }
    
    private void OnCollisionEnter(Collision spaceship)
    {
        collision = true;
    }
}
