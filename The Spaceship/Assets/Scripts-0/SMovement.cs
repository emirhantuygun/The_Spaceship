using UnityEngine;

public class SMovement : MonoBehaviour
{  
    Touch touch;
    float speedModifier;

    private void Start()
    {
        speedModifier = 0.0035f + (PlayerPrefs.GetInt("sens") * 6) / 10000f;
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y + touch.deltaPosition.y * speedModifier, transform.position.z);
            }
        }
              
        float x = Mathf.Clamp(transform.position.x, -1.3f, 1.3f);
        float y = Mathf.Clamp(transform.position.y, -1.8f, 3.5f);

        transform.position = new Vector3(x, y, transform.position.z);
    }
}
