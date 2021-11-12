using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class GuiHandler : MonoBehaviour
{
    //-------------------External
    public Material mat1;
    public Material mat2;
    public Text numberOfWinsP1;
    public Text numberOfWinsP2;
    public Text bestTime;
    public RawImage img1;
    public RawImage img2;
    //-------------------

    //Ready states
    bool p1;
    bool p2;

    //Controls mode
    bool controls;

    //Quit
    bool quitMode;

    //Input System
    Inputs inputs;

    private void Awake()
    {
        //Setup Inputs
        inputs = new Inputs();
        inputs.PlayerOne.Ready.performed += ctx => xButton();
        inputs.PlayerTwo.Ready.performed += ctx => p2Ready();

        inputs.PlayerOne.Options.performed += ctx => controls = true;
        inputs.PlayerOne.Boost.performed += ctx => cancel();
    }
    void Start()
    {
        //Set controls to true
        controls = true;
        quitMode = false;

        //Set color to default
        mat1.color = new Color(255, 0, 0);
        mat2.color = new Color(255, 0, 0);

        //Set total wins for players
        int wins1 = PlayerPrefs.GetInt("P1WINS");
        int wins2 = PlayerPrefs.GetInt("P2WINS");
        if(wins1 == 1)
        {
            numberOfWinsP1.text = "1 win";
        }
        else
        {
            numberOfWinsP1.text = wins1 + " wins";
        }
        if (wins2 == 1)
        {
            numberOfWinsP2.text = "1 win";
        }
        else
        {
            numberOfWinsP2.text = wins2 + " wins";
        }
        bestTime.text = "Best: " + PlayerPrefs.GetInt("BEST_MIN") + ":" + PlayerPrefs.GetInt("BEST_SEC");

    }

    void cancel()
    {
        //Check current gui state
        if(controls == true)
        {
            controls = false;
        }
        else if(quitMode == true)
        {
            quitMode = false;
        }else
        {
            quitMode = true;
        }
    }

    void xButton()
    {
        //Check if in quit mode
        if (quitMode)
        {
            //Close application
            Application.Quit();
        }
        else
        {
            p1Ready();
        }
    }

    private void FixedUpdate()
    {
        //Checks if controls is true
        if (controls)
        {
            img1.enabled = true;
        }
        else
        {
            img1.enabled = false;
        }

        if (quitMode)
        {
            img2.enabled = true;
        }
        else
        {
            img2.enabled = false;
        }
    }

    //Player one ready
    void p1Ready()
    {
        p1 = true;
        mat1.color = new Color(0, 255, 0);
        if(p2 == true)
        {
            startRace();
        }
    }

    //Player two Ready
    void p2Ready()
    {
        p2 = true;
        mat2.color = new Color(0, 255, 0);
        if (p1 == true)
        {
            startRace();
        }
    }


    //Start race (Open new scene)
    void startRace()
    {
        SceneManager.LoadScene(1);
    }



    //Input system
    private void OnEnable()
    {
        inputs.PlayerOne.Enable();
        inputs.PlayerTwo.Enable();
    }
    private void OnDisable()
    {
        inputs.PlayerOne.Disable();
        inputs.PlayerTwo.Disable();
    }
}
