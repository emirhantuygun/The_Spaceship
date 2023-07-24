using UnityEngine;

public class VehicleGenerator : MonoBehaviour
{
    public GameObject v0;
    public GameObject v1;
    public GameObject v2;
    public GameObject v3;
    public GameObject v4;
    public GameObject v5;
    public GameObject v6;
    public GameObject v7;
    public GameObject v8;
    public GameObject v9;
    public GameObject v10;
    public GameObject v11;
    public GameObject v12;
    public GameObject v13;
    public GameObject v14;
    public GameObject v15;
    public GameObject v16;
    public GameObject v17;
    public GameObject v18;
    public GameObject v19;
    public GameObject v20;

    public static GameObject currentvehicle;

    public void Start()
    {
        if (PlayerPrefs.GetInt("SelectedCar") == 0)
        {
            currentvehicle = Instantiate(v0, new Vector3(0, 0, 0), v0.transform.rotation);
            PlayerPrefs.SetInt("sens", 1);
            PlayerPrefs.SetInt("fuel", 1);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 1)
        {
            currentvehicle = Instantiate(v1, new Vector3(0, 0, 0), v1.transform.rotation);
            PlayerPrefs.SetInt("sens", 1);
            PlayerPrefs.SetInt("fuel", 2);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 2)
        {
            currentvehicle = Instantiate(v2, new Vector3(0, 0, 0), v2.transform.rotation);
            PlayerPrefs.SetInt("sens", 2);
            PlayerPrefs.SetInt("fuel", 1);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 3)
        {
            currentvehicle = Instantiate(v3, new Vector3(0, 0, 0), v3.transform.rotation);
            PlayerPrefs.SetInt("sens", 2);
            PlayerPrefs.SetInt("fuel", 3);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 4)
        {
            currentvehicle = Instantiate(v4, new Vector3(0, 0, 0), v4.transform.rotation);
            PlayerPrefs.SetInt("sens", 3);
            PlayerPrefs.SetInt("fuel", 2);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 5)
        {
            currentvehicle = Instantiate(v5, new Vector3(0, 0, 0), v5.transform.rotation);
            PlayerPrefs.SetInt("sens", 3);
            PlayerPrefs.SetInt("fuel", 4);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 6)
        {
            currentvehicle = Instantiate(v6, new Vector3(0, 0, 0), v6.transform.rotation);
            PlayerPrefs.SetInt("sens", 4);
            PlayerPrefs.SetInt("fuel", 3);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 7)
        {
            currentvehicle = Instantiate(v7, new Vector3(0, 0, 0), v7.transform.rotation);
            PlayerPrefs.SetInt("sens", 4);
            PlayerPrefs.SetInt("fuel", 5);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 8)
        {
            currentvehicle = Instantiate(v8, new Vector3(0, 0, 0), v8.transform.rotation);
            PlayerPrefs.SetInt("sens", 5);
            PlayerPrefs.SetInt("fuel", 4);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 9)
        {
            currentvehicle = Instantiate(v9, new Vector3(0, 0, 0), v9.transform.rotation);
            PlayerPrefs.SetInt("sens", 5);
            PlayerPrefs.SetInt("fuel", 6);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 10)
        {
            currentvehicle = Instantiate(v10, new Vector3(0, 0, 0), v10.transform.rotation);
            PlayerPrefs.SetInt("sens", 6);
            PlayerPrefs.SetInt("fuel", 5);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 11)
        {
            currentvehicle = Instantiate(v11, new Vector3(0, 0, 0), v11.transform.rotation);
            PlayerPrefs.SetInt("sens", 6);
            PlayerPrefs.SetInt("fuel", 7);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 12)
        {
            currentvehicle = Instantiate(v12, new Vector3(0, 0, 0), v12.transform.rotation);
            PlayerPrefs.SetInt("sens", 7);
            PlayerPrefs.SetInt("fuel", 6);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 13)
        {
            currentvehicle = Instantiate(v13, new Vector3(0, 0, 0), v13.transform.rotation);
            PlayerPrefs.SetInt("sens", 7);
            PlayerPrefs.SetInt("fuel", 8);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 14)
        {
            currentvehicle = Instantiate(v14, new Vector3(0, 0, 0), v14.transform.rotation);
            PlayerPrefs.SetInt("sens", 8);
            PlayerPrefs.SetInt("fuel", 7);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 15)
        {
            currentvehicle = Instantiate(v15, new Vector3(0, 0, 0), v15.transform.rotation);
            PlayerPrefs.SetInt("sens", 8);
            PlayerPrefs.SetInt("fuel", 9);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 16)
        {
            currentvehicle = Instantiate(v16, new Vector3(0, 0, 0), v16.transform.rotation);
            PlayerPrefs.SetInt("sens", 9);
            PlayerPrefs.SetInt("fuel", 8);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 17)
        {
            currentvehicle = Instantiate(v17, new Vector3(0, 0, 0), v17.transform.rotation);
            PlayerPrefs.SetInt("sens", 9);
            PlayerPrefs.SetInt("fuel", 10);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 18)
        {
            currentvehicle = Instantiate(v18, new Vector3(0, 0, 0), v18.transform.rotation);
            PlayerPrefs.SetInt("sens", 10);
            PlayerPrefs.SetInt("fuel", 9);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 19)
        {
            currentvehicle = Instantiate(v19, new Vector3(0, 0, 0), v19.transform.rotation);
            PlayerPrefs.SetInt("sens", 10);
            PlayerPrefs.SetInt("fuel", 10);
        }

        if (PlayerPrefs.GetInt("SelectedCar") == 20)
        {
            currentvehicle = Instantiate(v20, new Vector3(0, 0, 0), v20.transform.rotation);
            PlayerPrefs.SetInt("sens", 10);
            PlayerPrefs.SetInt("fuel", 10);
        }
    }
}
