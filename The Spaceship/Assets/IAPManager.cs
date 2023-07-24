using UnityEngine;
using UnityEngine.Purchasing;

public class IAPManager : MonoBehaviour
{
    int cash;
    public static bool purchased;

    string dollars2 = "dollars_2";
    string dollars3 = "dollars_3";
    string dollars5 = "dollars_5";
    string dollars7 = "dollars_7";
    string dollars9 = "dollars_9";
    string dollars10 = "dollars_10";

    public void OnPurchaseComplete(UnityEngine.Purchasing.Product product)
    {
        if(product.definition.id == dollars2)
        {
            cash = PlayerPrefs.GetInt("cash", 0);
            PlayerPrefs.SetInt("cash", cash + 5000);
            purchased = true;
        }
        
        if(product.definition.id == dollars3)
        {
            cash = PlayerPrefs.GetInt("cash", 0);
            PlayerPrefs.SetInt("cash", cash + 10000);
            purchased = true;
        }
        
        if(product.definition.id == dollars5)
        {
            cash = PlayerPrefs.GetInt("cash", 0);
            PlayerPrefs.SetInt("cash", cash + 20000);
            purchased = true;
        }
        
        if(product.definition.id == dollars7)
        {
            cash = PlayerPrefs.GetInt("cash", 0);
            PlayerPrefs.SetInt("cash", cash + 50000);
            purchased = true;
        }
        
        if(product.definition.id == dollars9)
        {
            cash = PlayerPrefs.GetInt("cash", 0);
            PlayerPrefs.SetInt("cash", cash + 75000);
            purchased = true;
        }
        
        if(product.definition.id == dollars10)
        {
            cash = PlayerPrefs.GetInt("cash", 0);
            PlayerPrefs.SetInt("cash", cash + 100000);
            purchased = true;
        }
    }  
    public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(product.definition.id + " failed because " + failureReason);
    }
}