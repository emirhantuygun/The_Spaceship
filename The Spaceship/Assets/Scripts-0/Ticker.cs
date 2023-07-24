using System.Collections;
using UnityEngine;

public class Ticker : MonoBehaviour
{
    public TickerItem tickerItemPrefab;
    [Range(0f, 100f)]
    public float itemDuration = 3.0f;
    public string[] fillerItems;

    float width;
    float pixelsPerSecond;
    TickerItem currentItem;
    bool wait = false;

    void Start()
    {
        width = GetComponent<RectTransform>().rect.width;
        pixelsPerSecond = width / itemDuration;
        AddTickerItem(fillerItems[0]);
        StartCoroutine(Timer());
    }
    
    void Update()
    {
        if(currentItem.GetXPosition <= -currentItem.GetWidth && wait == true) 
            AddTickerItem(fillerItems[Random.Range(0, fillerItems.Length)]);      
    }

    void AddTickerItem(string message)
    {
        currentItem = Instantiate(tickerItemPrefab, transform);
        currentItem.Initialize(width, pixelsPerSecond, message);
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        {
            wait = true;
        }
    }
}
