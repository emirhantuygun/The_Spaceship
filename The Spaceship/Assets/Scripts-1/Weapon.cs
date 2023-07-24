using UnityEngine;

public class Weapon : MonoBehaviour
{   
    float doubleTapTime = 0.2f;
    private int tapCount = 0;
    private float lastTapTime;

    public Transform bulletSpawnPoint1;
    public Transform bulletSpawnPoint2;
    public Transform bulletSpawnPoint3;
    public Transform bulletSpawnPoint4;
    public GameObject bulletPrefab;
    float bulletSpeed = 85f;

    private AudioSource audioSource;
    int counter;

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
        if(Buttons.sound == true)
        audioSource.Play();
       
        counter++;
        PlayerPrefs.SetInt("used", counter);

        var bullet1 = Instantiate(bulletPrefab, bulletSpawnPoint1.position, bulletPrefab.transform.rotation);
        bullet1.GetComponent<Rigidbody>().velocity = bulletSpawnPoint1.forward * bulletSpeed;
       
        var bullet2 = Instantiate(bulletPrefab, bulletSpawnPoint2.position, bulletPrefab.transform.rotation);
        bullet2.GetComponent<Rigidbody>().velocity = bulletSpawnPoint2.forward * bulletSpeed;

        if(PlayerPrefs.GetInt("SelectedCar") == 14)
        {
            var bullet3 = Instantiate(bulletPrefab, bulletSpawnPoint3.position, bulletPrefab.transform.rotation);
            bullet3.GetComponent<Rigidbody>().velocity = bulletSpawnPoint3.forward * bulletSpeed;

            var bullet4 = Instantiate(bulletPrefab, bulletSpawnPoint4.position, bulletPrefab.transform.rotation);
            bullet4.GetComponent<Rigidbody>().velocity = bulletSpawnPoint4.forward * bulletSpeed;
        }
    }
}
