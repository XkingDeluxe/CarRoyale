using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapHandler : MonoBehaviour
{
    //------------------------External
    public Transform p1;
    public Transform p2;
    public RawImage RedLight;
    public RawImage GreenLight;
    public RectTransform blue;
    public RectTransform red;
    public Rigidbody speed1;
    public Rigidbody speed2;
    public Text speed1Text;
    public Text speed2Text;
    public Text boost1Text;
    public Text boost2Text;
    public AudioSource beep1;
    public AudioSource beep2;
    //------------------------

    //Light variables
    Vector2 posRL;
    bool enabledRL;
    bool enabledGL;
    bool beepSound1;
    bool beepSound2;

    private void Start()
    {
        new Thread(countDown).Start();
    }

    //Countdown
    private async void countDown() {
        posRL = new Vector2(-135, 0);
        enabledRL = false;
        enabledGL = false;
        
        
        Thread.Sleep(3000);
        enabledRL = true;
        for (int i = 0; i < 3; i++)
        {
            beepSound1 = true;
            Thread.Sleep(1000);
            posRL += new Vector2(90, 0);
        }
        enabledRL = false;
        enabledGL = true;
        beepSound2 = true;
        PlayerOneController.start = true;
        PlayerTwoController.start = true;
        Thread.Sleep(1000);
        enabledGL = false;
    }

    private void FixedUpdate()
    {
        //Call functions
        movePointOnMinimap();
        updateText();

        //Listen to events because threads are weird with unity
        if (beepSound1)
        {
            beep1.Play();
            beepSound1 = false;
        }
        if (beepSound2)
        {
            beep2.Play();
            beepSound2 = false;
        }
        if (enabledRL)
        {
            RedLight.enabled = true;
            RedLight.rectTransform.anchoredPosition = posRL;
        }
        else
        {
            RedLight.enabled = false;
        }
        if (enabledGL)
        {
            GreenLight.enabled = true;
        }
        else
        {
            GreenLight.enabled = false;
        }
        
    }

    void movePointOnMinimap()
    {
        //Change blue dot on minimap with the blue car pos(dx-minimap/dx-mainMap, xminimap = a(xmap) + b --- dy-minimap/dy-mainMap, yminimap = a(ymap) + b)
        blue.anchoredPosition = new Vector2(p1.position.x * 0.043f + 320.65f, p1.position.z * 0.042f + 20.28f);
        //Change blue dot on minimap with the blue car pos(dx-minimap/dx-mainMap, xminimap = a(xmap) + b --- dy-minimap/dy-mainMap, yminimap = a(ymap) + b)
        red.anchoredPosition = new Vector2(p2.position.x * 0.043f + 320.65f, p2.position.z * 0.042f + 20.28f);
    }
    void updateText()
    {
        //Update Text
        speed1Text.text = Mathf.Round(speed1.velocity.magnitude * 1.5f) + " km/h";
        speed2Text.text = Mathf.Round(speed2.velocity.magnitude * 1.5f) + " km/h";
        boost1Text.text = PlayerOneController.boostAmount + " /100";
        boost2Text.text = PlayerTwoController.boostAmount + " /100";
    }
}

