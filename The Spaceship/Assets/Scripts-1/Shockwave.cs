using UnityEngine;

public class Shockwave : MonoBehaviour
{
    float doubleTapTime = 0.2f;
    private int tapCount = 0;
    private float lastTapTime;

    private AudioSource audioSource;

    public GameObject shockwave;
    public GameObject explosion;
    private float radius = 50f;

    int counter;
    public static bool shockscore;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        counter = 0;
        PlayerPrefs.SetInt("used", 0);
    }

    void Update()
    {
        if (Input.touchCount == 1 && counter < PlayerPrefs.GetInt("counter"))
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                tapCount++;

                if (tapCount == 1)
                {
                    lastTapTime = Time.time;
                }
                else if (tapCount == 2 && Time.time - lastTapTime < doubleTapTime)
                {
                    tapCount = 0;
                    lastTapTime = 0;
                    OnDoubleTap();
                }
                else if (tapCount > 2 || Time.time - lastTapTime > doubleTapTime)
                {
                    tapCount = 1;
                    lastTapTime = Time.time;
                }
            }
        }
    }

    public void OnDoubleTap()
    {
        if (Buttons.sound == true)
            audioSource.Play();

        counter++;
        PlayerPrefs.SetInt("used", counter);

        Instantiate(shockwave, gameObject.transform.position, gameObject.transform.rotation);

        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if (obj != gameObject && obj.CompareTag("Planets") && UnityEngine.Vector3.Distance(transform.position, obj.transform.position) <= radius)
            {
                Instantiate(explosion, obj.transform.position, obj.transform.rotation);
                shockscore = true;
                Destroy(obj);
            }
        }
    }
}
