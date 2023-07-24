using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
   
    public GameObject Canvas;
    public GameObject CanvasOfMarket;
    public GameObject CanvasOfSettings;
    public GameObject Panel;
    public GameObject InfoPanel;

    public GameObject shipstore;
    public GameObject packstore;
    public Button shipbutton;
    public Button packbutton;
    public GameObject line1;
    public GameObject line2;

    public GameObject voiceon;
    public GameObject voiceoff;
    public GameObject OffLine;
    
    public AudioSource audioSource1;
    public AudioSource audioSource2;

    public static bool beat = true;
    public static bool sound = true;

    private void Start()
    {
        if (beat == false)
        {
            audioSource1.volume = 0f;
            OffLine.SetActive(true);
        }

        if (sound == false)
        {
            voiceon.SetActive(false);
            voiceoff.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("Level", 1);
    }

    public void backformarket()
    {
        if(sound == true)
            audioSource2.Play();
        
        CanvasOfMarket.SetActive(false);
        Canvas.SetActive(true);
    }
    
    public void backforsettings()
    {
        if (sound == true)
            audioSource2.Play();
        
        CanvasOfSettings.SetActive(false);
        Canvas.SetActive(true);
    }
    
    public void backforinfopanel()
    {
        if (sound == true)
            audioSource2.Play();
        
        InfoPanel.SetActive(false);
        Panel.SetActive(true);
    }
    
    public void enterformarket()
    {
        if (sound == true)
            audioSource2.Play();
        
        Canvas.SetActive(false);
        CanvasOfMarket.SetActive(true);
        
        Color shipcolor = shipbutton.GetComponent<Image>().color;
        shipcolor.a = 1f;
        shipbutton.GetComponent<Image>().color = shipcolor;

        Color packcolor = packbutton.GetComponent<Image>().color;
        packcolor.a = 0.5f;
        packbutton.GetComponent<Image>().color = packcolor;

        if (packstore.activeSelf)
            packstore.SetActive(false);

        shipstore.SetActive(true);

        if (line2.activeSelf)
            line2.SetActive(false);

        line1.SetActive(true);

    }
    
    public void enterforsettings()
    {
        if (sound == true)
            audioSource2.Play();
        
        Canvas.SetActive(false);
        CanvasOfSettings.SetActive(true);
    }
    
    public void enterforinfopanel()
    {
        if (sound == true)
            audioSource2.Play();
        
        Panel.SetActive(false);
        InfoPanel.SetActive(true);
    }

    public void ships()
    {
        if (sound == true)
            audioSource2.Play();

        Color shipcolor = shipbutton.GetComponent<Image>().color;
        shipcolor.a = 1f;
        shipbutton.GetComponent<Image>().color = shipcolor;

        Color packcolor = packbutton.GetComponent<Image>().color;
        packcolor.a = 0.5f;
        packbutton.GetComponent<Image>().color = packcolor;

        if(packstore.activeSelf)
            packstore.SetActive(false);
       
        shipstore.SetActive(true);

        if (line2.activeSelf)
            line2.SetActive(false);

        line1.SetActive(true);
    }
    
    public void packs()
    {
        if (sound == true)
            audioSource2.Play();

        Color shipcolor = shipbutton.GetComponent<Image>().color;
        shipcolor.a = 0.5f;
        shipbutton.GetComponent<Image>().color = shipcolor;

        Color packcolor = packbutton.GetComponent<Image>().color;
        packcolor.a = 1f;
        packbutton.GetComponent<Image>().color = packcolor;

        if (shipstore.activeSelf)
            shipstore.SetActive(false);

        packstore.SetActive(true); 
        
        if (line1.activeSelf)
            line1.SetActive(false);

        line2.SetActive(true);
    }

    public void voiceOn()
    {
        voiceon.SetActive(false);
        voiceoff.SetActive(true);
        sound = false;
    }

    public void voiceOff() 
    { 
        voiceoff.SetActive(false);
        voiceon.SetActive(true);
        sound = true;
    }

    public void music() 
    {
        if (!OffLine.activeSelf)
        {
            audioSource1.volume = 0f;
            OffLine.SetActive(true);
            beat = false;
        }

        else
        {
            audioSource1.volume = 0.5f;
            OffLine.SetActive(false);
            beat = true;
        }
    }

    public void rating()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=8853955325713753955");
    }
    public void youtube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC4m-gbWfbyseGGTYxG0DESQ");
    }
    public void facebook()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=100091332591271");
    }
    public void instagram()
    {
        Application.OpenURL("https://www.instagram.com/schismstudios/");
    }
    public void twitter()
    {
        Application.OpenURL("https://twitter.com/schismstudioss");
    }
    public void tiktok()
    {
        Application.OpenURL("https://www.tiktok.com/@schismstudios");
    }
}
