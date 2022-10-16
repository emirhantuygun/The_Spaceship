using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingsEnter : MonoBehaviour
{
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject CanvasofSettings;


    void Start()
    {
        Button setttings = this.GetComponent<Button>();
        setttings.onClick.AddListener(taskOnClick);
    }

    void taskOnClick()
    {
        Canvas.SetActive(false);
        CanvasofSettings.SetActive(true);
    }
}
