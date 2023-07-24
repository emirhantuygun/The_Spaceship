using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public static bool changes = false;
    
    public int currentCarIndex;

    public AudioSource audiosource;
    public GameObject[] CarModels;
    public GameObject[] SignModels;
    public CarInfos[] CarInfos;
    public Button button;
    public TMP_Text index;

    public TMP_Text sensitivity;
    public TMP_Text fuelEfficiency;
    public TMP_Text ability;

    void Start()
    {
        foreach (CarInfos car in CarInfos)
        {
            if (car.price == 0)          
                car.isUnlocked = true;
            
            else
                car.isUnlocked = PlayerPrefs.GetInt(car.name, 0)==0 ? false: true;   
        }
                      
        currentCarIndex = PlayerPrefs.GetInt("SelectedCar", 0);
        index.text = (currentCarIndex + 1) + "/21";

        foreach (GameObject car in CarModels)
            car.SetActive(false);

        CarModels[currentCarIndex].SetActive(true);

        foreach (GameObject sign in SignModels)
            sign.SetActive(false);

        SignModels[currentCarIndex].SetActive(true);

        bargenerator();
    }

    void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        CarInfos c = CarInfos[currentCarIndex];

        if (c.isUnlocked)
            button.gameObject.SetActive(false);

        else
        {
            button.gameObject.SetActive(true);
            button.GetComponentInChildren<TextMeshProUGUI>().text = "$ " + c.price;
            
            if (c.price < PlayerPrefs.GetInt("cash", 0))            
                button.interactable = true;
            
            else            
                button.interactable = false;           
        }
    }


    public void ChangeNext()
    {
        if(Buttons.sound == true)
            audiosource.Play();
        
        CarModels[currentCarIndex].SetActive(false);
        SignModels[currentCarIndex].SetActive(false);

        currentCarIndex++;

        if (currentCarIndex == CarModels.Length)
            currentCarIndex = 0;

        index.text = (currentCarIndex + 1) + "/21";

        CarModels[currentCarIndex].SetActive(true);
        SignModels[currentCarIndex].SetActive(true);

        bargenerator();

        CarInfos c = CarInfos[currentCarIndex];
        
        if (!c.isUnlocked)
            return;

        PlayerPrefs.SetInt("SelectedCar", currentCarIndex);
    }

    public void ChangePrevious()
    {
        if (Buttons.sound == true)
            audiosource.Play();

        CarModels[currentCarIndex].SetActive(false);
        SignModels[currentCarIndex].SetActive(false);

        currentCarIndex--;

        if (currentCarIndex == -1)
            currentCarIndex = CarModels.Length - 1;

        index.text = (currentCarIndex + 1) + "/21";

        CarModels[currentCarIndex].SetActive(true);
        SignModels[currentCarIndex].SetActive(true);

        bargenerator();

        CarInfos c = CarInfos[currentCarIndex];
        if (!c.isUnlocked)
            return;

        PlayerPrefs.SetInt("SelectedCar", currentCarIndex);
    }

    public void UnlockCar()
    {
        if (Buttons.sound == true)
            audiosource.Play();

        CarInfos c = CarInfos[currentCarIndex];

        PlayerPrefs.SetInt(c.name, 1);
        PlayerPrefs.SetInt("SelectedCar", currentCarIndex);
        c.isUnlocked = true;
        PlayerPrefs.SetInt("cash", PlayerPrefs.GetInt("cash", 0) - c.price);
        changes = true;
    }

    void bargenerator()
    {
        CarInfos c = CarInfos[currentCarIndex];

        sensitivity.text = "";
        for (int i = 0; i < c.sensitivity; i++)
        {
            sensitivity.text += "|  ";
        }

        fuelEfficiency.text = "";
        for (int i = 0; i < c.fuelefficiency; i++)
        {
            fuelEfficiency.text += "|  ";
        }

        if(currentCarIndex == 0)
        {
            ability.text = "none";
        }

        if(currentCarIndex == 1)
        {
            ability.text = "time slowing (1 time)";
            PlayerPrefs.SetInt("counter", 1);
        }

        if(currentCarIndex == 2)
        {
            ability.text = "weapon (5 shots)";
            PlayerPrefs.SetInt("counter", 5);
        }

        if (currentCarIndex == 3)
        {
            ability.text = "shockwave (1 time)";
            PlayerPrefs.SetInt("counter", 1);
        }

        if (currentCarIndex == 4)
        {
            ability.text = "weapon (10 shots)";
            PlayerPrefs.SetInt("counter", 10);
        }

        if (currentCarIndex == 5)
        {
            ability.text = "shockwave (2 times)";
            PlayerPrefs.SetInt("counter", 2);
        }

        if (currentCarIndex == 6)
        {
            ability.text = "time slowing (3 times)"; 
            PlayerPrefs.SetInt("counter", 3);
        }

        if (currentCarIndex == 7)
        {
            ability.text = "shockwave (3 times)";
            PlayerPrefs.SetInt("counter", 3);
        }

        if (currentCarIndex == 8)
        {
            ability.text = "shockwave (5 times)";
            PlayerPrefs.SetInt("counter", 5);
        }

        if (currentCarIndex == 9)
        {
            ability.text = "time slowing (5 times)";
            PlayerPrefs.SetInt("counter", 5);
        }

        if (currentCarIndex == 10)
        {
            ability.text = "weapon (20 shots)";
            PlayerPrefs.SetInt("counter", 20);
        }

        if (currentCarIndex == 11)
        {
            ability.text = "shockwave (7 times)";
            PlayerPrefs.SetInt("counter", 7);
        }

        if (currentCarIndex == 12)
        {
            ability.text = "shockwave (10 times)";
            PlayerPrefs.SetInt("counter", 10);
        }

        if (currentCarIndex == 13)
        {
            ability.text = "weapon (30 shots)";
            PlayerPrefs.SetInt("counter", 30);
        }

        if (currentCarIndex == 14)
        {
            ability.text = "weapon (40 shots)";
            PlayerPrefs.SetInt("counter", 40);
        }

        if (currentCarIndex == 15)
        {
            ability.text = "time slowing (10 times)";
            PlayerPrefs.SetInt("counter", 10);
        }

        if (currentCarIndex == 16)
        {
            ability.text = "weapon (50 shots)";
            PlayerPrefs.SetInt("counter", 50);
        }

        if (currentCarIndex == 17)
        {
            ability.text = "time slowing (15 times)";
            PlayerPrefs.SetInt("counter", 15);
        }

        if (currentCarIndex == 18)
        {
            ability.text = "weapon (100 shots)";
            PlayerPrefs.SetInt("counter", 100);
        }

        if (currentCarIndex == 19)
        {
            ability.text = "shockwave (20 times)";
            PlayerPrefs.SetInt("counter", 20);
        }

        if (currentCarIndex == 20)
        {
            ability.text = "weapon (limitless shots)";
            PlayerPrefs.SetInt("counter", 9999);
        }
    }
}
