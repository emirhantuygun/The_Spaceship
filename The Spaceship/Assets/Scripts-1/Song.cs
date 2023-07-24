using UnityEngine;

public class Song: MonoBehaviour
{    
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        if(Buttons.beat == true)
        Invoke("PlayDelayed", 1f);
    }

    private void PlayDelayed()
    {
        audioSource.Play();
    }

    private void Update()
    {
        if(Failing.isDead)
            Destroy(gameObject);
    }
}
